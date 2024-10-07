using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using CSharpTest.Models;
using CSharpTest.Services;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization; // Asegúrate de tener esta referencia

namespace CSharpTest.Controllers.v1.Guests;

[ApiController]
[Route("api/v1/Guests/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Guests")]
public class GuestGetController : GuestController
{
    public readonly GuestServices GuestServices;

    public GuestGetController(GuestServices GuestServices) : base(GuestServices)
    {
        this.GuestServices = GuestServices;
    }

    /// <summary>
    /// Obtiene todos los huéspedes.
    /// </summary>
    /// <returns>Una lista de todos los huéspedes.</returns>
    /// <response code="200">Devuelve una lista de huéspedes.</response>
    [HttpGet]
    [Authorize]
    [SwaggerOperation(Summary = "Obtiene todos los huéspedes", Description = "Devuelve una lista de todos los huéspedes.")]
    [SwaggerResponse(200, "Lista de huéspedes obtenida exitosamente.", typeof(IEnumerable<Guest>))]
    public async Task<ActionResult<IEnumerable<Guest>>> GetAll()
    {
        var Guests = await GuestServices.GetAll();
        return Ok(Guests);
    }

    /// <summary>
    /// Obtiene un huésped por su ID.
    /// </summary>
    /// <param name="id">El ID del huésped a obtener.</param>
    /// <returns>El huésped correspondiente al ID proporcionado.</returns>
    /// <response code="200">Devuelve el huésped encontrado.</response>
    /// <response code="204">Si el huésped no existe.</response>
    [HttpGet("{id}")]
    [Authorize]
    [SwaggerOperation(Summary = "Obtiene un huésped por ID", Description = "Devuelve el huésped correspondiente al ID proporcionado.")]
    [SwaggerResponse(200, "Huésped encontrado.", typeof(Guest))]
    [SwaggerResponse(204, "Huésped no encontrado.")]
    public async Task<ActionResult<Guest>> GetById([FromRoute] int id)
    {
        if (await GuestServices.CheckExistence(id) == false)
        {
            return NoContent();
        }
        else
        {
            var Guest = await GuestServices.GetById(id);
            return Ok(Guest);
        }
    }


/// <summary>
/// Obtiene un invitado por palabra clave.
/// </summary>
/// <param name="key">La palabra clave para buscar.</param>
/// <returns>Lista de reservas que coinciden con la palabra clave.</returns>
/// <response code="200">Devuelve la lista de reservas encontradas.</response>
/// <response code="404">Si no se encuentran reservas.</response>
/// <response code="500">Si ocurre un error durante el proceso.</response>
[HttpGet("GetFromKeyWord/{key}")]
[Authorize]
[SwaggerOperation(Summary = "Obtiene una reserva por palabra clave", Description = "Devuelve la lista de reservas correspondientes a la palabra clave proporcionada.")]
[SwaggerResponse(200, "Reservas encontradas.")]
[SwaggerResponse(404, "No se encontraron reservas.")]
[SwaggerResponse(500, "Un error ocurrió durante el proceso.")]
public async Task<ActionResult<List<Guest>>> GetBookingByKeyWord([FromRoute] string key)
{
    var guests = await GuestServices.GetAll();
    
    // Filtrar invitados por palabra clave
    var foundGuests = guests.Where(g => g.Guest_first_name.Contains(key) ||
                                        g.Guest_last_name.Contains(key) ||
                                        g.Guest_email.Contains(key) ||
                                        g.Guest_identification_number.Contains(key) ||
                                        g.Guest_phone_number.Contains(key)).ToList();
    
    if (!foundGuests.Any())
    {
        return NotFound();
    }

    try
    {
        return Ok(foundGuests.Distinct().ToList()); // Eliminar duplicados si es necesario
    }
    catch (DbUpdateException)
    {
        return StatusCode(StatusCodes.Status500InternalServerError, "Un error ocurrió durante el proceso.");
    }
}

}

