using Microsoft.AspNetCore.Mvc;
using CSharpTest.DTOs.Requests;
using CSharpTest.Models;
using CSharpTest.Services;

namespace CSharpTest.Controllers.v1.Rooms;

[ApiController]
[Route("api/v1/Rooms/[controller]")]
[ApiExplorerSettings(GroupName ="v1")]
[Tags("Rooms")]
public class RoomCreateController : RoomController
{
    private readonly RoomServices RoomServices;

    public RoomCreateController(RoomServices RoomServices) : base(RoomServices)
    {
        this.RoomServices = RoomServices;
    }

    [HttpPost]
    public async Task<IActionResult> CreateNewRoom([FromBody]RoomDTO RoomDTO)
    {
        if(ModelState.IsValid == false)
        {
            return BadRequest("The model is bad done");
        }
        else if(RoomDTO == null)
        {
            return BadRequest("The model can not be null");
        }
        else
        {
            var newRoom = new Room(
                RoomDTO.Room_number,
                RoomDTO.Room_price_per_night,
                RoomDTO.Room_availability,
                RoomDTO.Room_max_occupancy_people,
                RoomDTO.Room_type_id
            );
            await RoomServices.Add(newRoom);
            return Ok(newRoom);
        }
    }
}