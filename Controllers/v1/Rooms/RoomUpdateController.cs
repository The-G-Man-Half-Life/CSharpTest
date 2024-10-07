using System.Timers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSharpTest.DTOs.Requests;
using CSharpTest.Models;
using CSharpTest.Repositories.Interfaces;
using CSharpTest.Services;

namespace CSharpTest.Controllers.v1.Rooms;

[ApiController]
[Route("api/v1/Rooms/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Rooms")]
public class RoomUpdateController : RoomController
{
    private readonly RoomServices RoomServices;

    public RoomUpdateController(RoomServices RoomServices) : base(RoomServices)
    {
        this.RoomServices = RoomServices;
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Room?>> UpdateRoom([FromRoute] int id, [FromBody] RoomDTO RoomDTO)
    {
        if(await RoomServices.CheckExistence(id)== false)
        {
            return NotFound("No se encontro a ningun transportador con ese id");
        }
        if (ModelState.IsValid == false)
        {
            return NotFound("El modelo debe de ser valido");
        }
        var Room = await RoomServices.GetById2(id);
        if (Room == null)
        {
            return NotFound("No se encontro el objeto por su id");
        }
        else
        {
            Room.Room_id = id;
            Room.Room_number = RoomDTO.Room_number;
            Room.Room_price_per_night = RoomDTO.Room_price_per_night;
            Room.Room_availability = RoomDTO.Room_availability;
            Room.Room_max_occupancy_people = RoomDTO.Room_max_occupancy_people;
            Room.Room_type_id = RoomDTO.Room_type_id;
            await RoomServices.Update(Room);
            return Ok("se agrego exitosamente");
        }
    }
}