using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSharpTest.DTOs.Requests;
using CSharpTest.Models;
using CSharpTest.Services;
using Swashbuckle.AspNetCore.Annotations; // Asegúrate de tener esta referencia

namespace CSharpTest.Controllers.v1.Room_types;

[ApiController]
[Route("api/v1/Room_types/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Room_types")]
public class Room_typeCreateController : Room_typeController
{
    private readonly Room_typeServices Room_typeServices;

    public Room_typeCreateController(Room_typeServices Room_typeServices) : base(Room_typeServices)
    {
        this.Room_typeServices = Room_typeServices;
    }

    /// <summary>
    /// Crea un nuevo tipo de habitación.
    /// </summary>
    /// <param name="Room_typeDTO">Los datos del nuevo tipo de habitación.</param>
    /// <returns>El nuevo tipo de habitación creado.</returns>
    /// <response code="200">Tipo de habitación creado exitosamente.</response>
    /// <response code="400">Si el modelo es inválido o nulo.</response>
    [HttpPost]
    [SwaggerOperation(Summary = "Crea un nuevo tipo de habitación", Description = "Permite crear un nuevo tipo de habitación.")]
    [SwaggerResponse(200, "Tipo de habitación creado exitosamente.", typeof(Room_type))]
    [SwaggerResponse(400, "El modelo es inválido o nulo.")]
    public async Task<IActionResult> CreateNewRoom_type([FromBody] Room_typeDTO Room_typeDTO)
    {
        if (ModelState.IsValid == false)
        {
            return BadRequest("El modelo es inválido.");
        }
        else if (Room_typeDTO == null)
        {
            return BadRequest("El modelo no puede ser nulo.");
        }
        else
        {
            try
            {
                var newRoom_type = new Room_type(
                    Room_typeDTO.Room_type_name,
                    Room_typeDTO.Room_type_description
                );
                await Room_typeServices.Add(newRoom_type);
                return Ok(newRoom_type);
            }
            catch (DbUpdateException dbEX)
            {
                throw new Exception("Ocurrió un error.", dbEX);
            }
        }
    }
}
