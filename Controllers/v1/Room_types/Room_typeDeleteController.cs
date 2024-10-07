using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSharpTest.Services;

namespace CSharpTest.Controllers.v1.Room_types;

[ApiController]
[Route("api/v1/Room_types/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Room_types")]

public class Room_typeDeleteController : Room_typeController
{
    public readonly Room_typeServices Room_typeServices;

    public Room_typeDeleteController(Room_typeServices Room_typeServices): base(Room_typeServices)
    {
        this.Room_typeServices = Room_typeServices;
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteARoom_type([FromRoute] int id)
    {
        if(await Room_typeServices.CheckExistence(id) == false)
        {
            return NotFound();
        }
        else
        {
            await Room_typeServices.Delete(id);
            return Ok("se elimino exitosamente");
        }
    }
}