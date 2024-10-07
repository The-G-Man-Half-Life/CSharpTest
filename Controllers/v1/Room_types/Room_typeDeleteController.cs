using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSharpTest.Services;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.AspNetCore.Authorization; // Asegúrate de tener esta referencia

namespace CSharpTest.Controllers.v1.Room_types;

[ApiController]
[Route("api/v1/Room_types/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Room_types")]
public class Room_typeDeleteController : Room_typeController
{
    public readonly Room_typeServices Room_typeServices;

    public Room_typeDeleteController(Room_typeServices Room_typeServices) : base(Room_typeServices)
    {
        this.Room_typeServices = Room_typeServices;
    }

    /// <summary>
    /// Elimina un tipo de habitación por su ID.
    /// </summary>
    /// <param name="id">El ID del tipo de habitación a eliminar.</param>
    /// <returns>Un mensaje de éxito o error.</returns>
    /// <response code="200">Tipo de habitación eliminado exitosamente.</response>
    /// <response code="404">Si el tipo de habitación no existe.</response>
    [HttpDelete("{id}")]
    [Authorize]
    [SwaggerOperation(Summary = "Elimina un tipo de habitación", Description = "Permite eliminar un tipo de habitación por su ID.")]
    [SwaggerResponse(200, "Tipo de habitación eliminado exitosamente.")]
    [SwaggerResponse(404, "Tipo de habitación no encontrado.")]
    public async Task<IActionResult> DeleteARoom_type([FromRoute] int id)
    {
        if (await Room_typeServices.CheckExistence(id) == false)
        {
            return NotFound();
        }
        else
        {
            await Room_typeServices.Delete(id);
            return Ok("Se eliminó exitosamente.");
        }
    }
}
