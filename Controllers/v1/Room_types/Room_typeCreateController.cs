using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSharpTest.DTOs.Requests;
using CSharpTest.Models;
using CSharpTest.Services;

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
    [HttpPost]
    public async Task<IActionResult> CreateNewRoom_type([FromBody] Room_typeDTO Room_typeDTO)
    {
        if (ModelState.IsValid == false)
        {
            return BadRequest("The model is bad done");
        }
        else if (Room_typeDTO == null)
        {
            return BadRequest("The model can not be null");
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
                throw new Exception("Un error ocurrio",dbEX);
            }

        }
    }
}

