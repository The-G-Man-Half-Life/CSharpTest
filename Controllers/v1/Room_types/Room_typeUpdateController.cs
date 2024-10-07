using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSharpTest.DTOs.Requests;
using CSharpTest.Models;
using CSharpTest.Services;
using Swashbuckle.AspNetCore.Annotations; // Asegúrate de tener esta referencia
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace CSharpTest.Controllers.v1.Room_types;

[ApiController]
[Route("api/v1/Room_types/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Room_types")]
public class Room_typeUpdateController : Room_typeController
{
    public readonly Room_typeServices Room_typeServices;

    public Room_typeUpdateController(Room_typeServices Room_typeServices) : base(Room_typeServices)
    {
        this.Room_typeServices = Room_typeServices;
    }

    /// <summary>
    /// Actualiza un tipo de habitación existente.
    /// </summary>
    /// <param name="id">El ID del tipo de habitación a actualizar.</param>
    /// <param name="Room_typeDTO">El modelo con los nuevos datos.</param>
    /// <returns>Resultado de la operación de actualización.</returns>
    /// <response code="200">Actualización exitosa.</response>
    /// <response code="204">Tipo de habitación no encontrado.</response>
    /// <response code="400">Modelo inválido o vacío.</response>
    /// <response code="500">Error en el servidor al procesar la solicitud.</response>
    [HttpPut("{id}")]
    [Authorize]
    [SwaggerOperation(Summary = "Actualiza un tipo de habitación existente", Description = "Actualiza los detalles de un tipo de habitación específico.")]
    [SwaggerResponse(200, "Actualización exitosa.", typeof(Room_type))]
    [SwaggerResponse(204, "Tipo de habitación no encontrado.")]
    [SwaggerResponse(400, "Modelo inválido o vacío.")]
    [SwaggerResponse(500, "Error en el servidor al procesar la solicitud.")]
    public async Task<ActionResult> UpdateARoom_type([FromRoute] int id, [FromBody] Room_typeDTO Room_typeDTO)
    {
        if (ModelState.IsValid == false)
        {
            return NoContent();
        }
        else if (Room_typeDTO == null)
        {
            return BadRequest("No puede hacer un modelo vacío");
        }
        else if (await Room_typeServices.CheckExistence(id) == false)
        {
            return NoContent();
        }
        else
        {
            try
            {
                var foundRoom_type = await Room_typeServices.GetById(id);
                foundRoom_type.Room_type_id = id;
                foundRoom_type.Room_type_name = Room_typeDTO.Room_type_name;
                foundRoom_type.Room_type_description = Room_typeDTO.Room_type_description;

                await Room_typeServices.Update(foundRoom_type);
                return Ok(foundRoom_type);
            }
            catch (DbUpdateException dbEX)
            {
                throw new DbUpdateException("Un error ocurrió durante el proceso", dbEX);
            }
        }
    }
}
