using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSharpTest.Models;
using CSharpTest.Services;
using CSharpTest.DTOs.Requests;

namespace CSharpTest.Controllers.v1.Rooms
{
    [ApiController]
    [Route("api/v1/Rooms/[controller]")]
    [ApiExplorerSettings(GroupName ="v1")]
    [Tags("Rooms")]
    public class RoomGetController : RoomController
    {
        private readonly RoomServices RoomServices;

        public RoomGetController(RoomServices RoomServices) : base(RoomServices)
        {
            this.RoomServices = RoomServices;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Room>>> GetAll()
        {
            try
            {
                var Rooms = await RoomServices.GetAll();
                return Ok(Rooms);
            }
            catch (DbUpdateException)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Un error ocurrió durante el proceso");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RoomDTO>> GetRoomById([FromRoute]int id)
        {
            if (await RoomServices.CheckExistence(id) == false)
            {
                return NotFound();
            }
            try
            {
                var foundRoom = await RoomServices.GetById(id);
                return Ok(foundRoom);
            }
            catch (DbUpdateException)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Un error ocurrió durante el proceso");
            }
        }
    }
}
