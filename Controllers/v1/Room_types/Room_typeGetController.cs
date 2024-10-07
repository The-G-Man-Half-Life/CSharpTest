using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSharpTest.Models;
using CSharpTest.Services;
using Swashbuckle.AspNetCore.Annotations; // Asegúrate de tener esta referencia
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpTest.Controllers.v1.Room_types;

[ApiController]
[Route("api/v1/Room_types/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Room_types")]
public class Room_typeGetController : Room_typeController
{
    public readonly Room_typeServices Room_typeServices;

    public Room_typeGetController(Room_typeServices Room_typeServices) : base(Room_typeServices)
    {
        this.Room_typeServices = Room_typeServices;
    }

    /// <summary>
    /// Obtiene todos los tipos de habitación.
    /// </summary>
    /// <returns>Una lista de tipos de habitación.</returns>
    /// <response code="200">Lista de tipos de habitación obtenida exitosamente.</response>
    /// <response code="500">Error en el servidor al procesar la solicitud.</response>
    [HttpGet]
    [SwaggerOperation(Summary = "Obtiene todos los tipos de habitación", Description = "Devuelve una lista de todos los tipos de habitación.")]
    [SwaggerResponse(200, "Lista de tipos de habitación obtenida exitosamente.", typeof(IEnumerable<Room_type>))]
    [SwaggerResponse(500, "Error en el servidor al procesar la solicitud.")]
    public async Task<ActionResult<IEnumerable<Room_type>>> GetAllRoom_types()
    {
        try
        {
            var Room_types = await Room_typeServices.GetAll();
            return Ok(Room_types);
        }
        catch (DbUpdateException dbEX)
        {
            throw new DbUpdateException($"Un error ocurrió durante el proceso: {dbEX.Message}");
        }
    }

    /// <summary>
    /// Obtiene un tipo de habitación por su ID.
    /// </summary>
    /// <param name="id">El ID del tipo de habitación a obtener.</param>
    /// <returns>El tipo de habitación encontrado o un mensaje de error.</returns>
    /// <response code="200">Tipo de habitación encontrado exitosamente.</response>
    /// <response code="204">Tipo de habitación no encontrado.</response>
    /// <response code="500">Error en el servidor al procesar la solicitud.</response>
    [HttpGet("{id}")]
    [SwaggerOperation(Summary = "Obtiene un tipo de habitación por ID", Description = "Devuelve un tipo de habitación específico basado en su ID.")]
    [SwaggerResponse(200, "Tipo de habitación encontrado exitosamente.", typeof(Room_type))]
    [SwaggerResponse(204, "Tipo de habitación no encontrado.")]
    [SwaggerResponse(500, "Error en el servidor al procesar la solicitud.")]
    public async Task<ActionResult<Room_type>> GetById([FromRoute] int id)
    {
        if (await Room_typeServices.CheckExistence(id) == false)
        {
            return NoContent();
        }
        else
        {
            try
            {
                var Room_typeFound = await Room_typeServices.GetById(id);
                return Ok(Room_typeFound);
            }
            catch (DbUpdateException dbEX)
            {
                throw new DbUpdateException("Un error ocurrió durante el proceso", dbEX);
            }
        }
    }
}
