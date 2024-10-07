using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSharpTest.Models;
using CSharpTest.Services;

namespace CSharpTest.Controllers.v1.Room_types;
    
[ApiController]
[Route("api/v1/Room_types/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags ("Room_types")]
public class Room_typeGetController : Room_typeController
{
    public readonly Room_typeServices Room_typeServices;

    public Room_typeGetController(Room_typeServices Room_typeServices): base(Room_typeServices)
    {
        this.Room_typeServices = Room_typeServices;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Room_type>>> GetAllRoom_types()
    {
        try
        {
            var Room_types = await Room_typeServices.GetAll();
            return Ok(Room_types);
        }
        catch (DbUpdateException dbEX)
        {
            
            throw new DbUpdateException($"Un error ocurrio durante el proceso {dbEX.Message}");
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Room_type>> GetById([FromRoute] int id)
    {
        if(await Room_typeServices.CheckExistence(id) == false)
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
                
                throw new DbUpdateException("Un error ocurrio durante el proceso", dbEX);
            }

        }
    }
}