using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSharpTest.Repositories.Interfaces;
using CSharpTest.Services;

namespace CSharpTest.Controllers.v1.Rooms;

[ApiController]
[Route("api/v1/Rooms/[controller]")]
[ApiExplorerSettings(GroupName ="v1")]
[Tags("Rooms")]
public class RoomDeleteController: RoomController
{
    private readonly RoomServices RoomServices;

    public RoomDeleteController(RoomServices RoomServices) : base(RoomServices)
    {
        this.RoomServices = RoomServices;
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteRoom([FromRoute] int id)
    {
        if(await RoomServices.CheckExistence(id)== false)
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
                
                throw new DbUpdateException("un error ocurrio durante el proceso",dbEX);
            }
        }
    }
}