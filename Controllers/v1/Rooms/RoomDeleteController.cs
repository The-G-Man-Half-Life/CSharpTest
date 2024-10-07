using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSharpTest.Services;
using Swashbuckle.AspNetCore.Annotations; // Asegúrate de tener esta referencia
using System.Threading.Tasks;

namespace CSharpTest.Controllers.v1.Rooms;

[ApiController]
[Route("api/v1/Rooms/[controller]")]
[ApiExplorerSettings(GroupName ="v1")]
[Tags("Rooms")]
public class RoomDeleteController : RoomController
{
    private readonly RoomServices RoomServices;

    public RoomDeleteController(RoomServices RoomServices) : base(RoomServices)
    {
        this.RoomServices = RoomServices;
    }

    /// <summary>
    /// Elimina una habitación por su ID.
    /// </summary>
    /// <param name="id">ID de la habitación a eliminar.</param>
    /// <returns>Resultado de la operación de eliminación.</returns>
    /// <response code="200">Eliminación exitosa de la habitación.</response>
    /// <response code="400">La habitación no existe.</response>
    [HttpDelete("{id}")]
    [SwaggerOperation(Summary = "Elimina una habitación", Description = "Elimina una habitación existente utilizando su ID.")]
    [SwaggerResponse(200, "Eliminación exitosa de la habitación.")]
    [SwaggerResponse(400, "La habitación no existe.")]
    public async Task<IActionResult> DeleteRoom([FromRoute] int id)
    {
        if (await RoomServices.CheckExistence(id) == false)
        {
            return BadRequest("no existe");
        }
        else
        {
            try
            {
                await RoomServices.Delete(id);
                return Ok("fue un exito");
            }
            catch (DbUpdateException dbEX)
            {
                throw new DbUpdateException("un error ocurrio durante el proceso", dbEX);
            }
        }
    }
}
