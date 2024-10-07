using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSharpTest.DTOs.Requests;
using CSharpTest.Models;
using CSharpTest.Services;

namespace CSharpTest.Controllers.v1.Room_types;

[ApiController]
[Route("api/v1/Room_types/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags ("Room_types")]
public class Room_typeUpdateController : Room_typeController
{
    public readonly Room_typeServices Room_typeServices;

    public Room_typeUpdateController(Room_typeServices Room_typeServices): base(Room_typeServices)
    {
        this.Room_typeServices = Room_typeServices;
    }

    [HttpPut("{id}")]


    public async Task<ActionResult> UpdateARoom_type([FromRoute] int id, [FromBody] Room_typeDTO Room_typeDTO)
    {
        if(ModelState.IsValid == false)
        {
            return NoContent();
        }
        else if(ModelState == null)
        {
            return BadRequest("No puede hacer un modelo vacio");
        }
        else if(await Room_typeServices.CheckExistence(id) == false)
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
                throw new DbUpdateException("Un error ocurrio durante el proceso",dbEX);
            }
        }
    }
}