using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using CSharpTest.Models;
using CSharpTest.Services;
using Swashbuckle.AspNetCore.Annotations; // Asegúrate de tener esta referencia

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
}
