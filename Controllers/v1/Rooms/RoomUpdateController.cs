using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSharpTest.DTOs.Requests;
using CSharpTest.Models;
using CSharpTest.Services;
using Swashbuckle.AspNetCore.Annotations; // Asegúrate de tener esta referencia

namespace CSharpTest.Controllers.v1.Rooms
{
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

        /// <summary>
        /// Actualiza los detalles de una habitación.
        /// </summary>
        /// <param name="id">ID de la habitación a actualizar.</param>
        /// <param name="RoomDTO">Objeto con los nuevos detalles de la habitación.</param>
        /// <returns>Detalles de la habitación actualizada.</returns>
        /// <response code="200">Actualización exitosa.</response>
        /// <response code="404">La habitación no fue encontrada.</response>
        /// <response code="400">El modelo no es válido.</response>
        [HttpPut("{id}")]
        [SwaggerOperation(Summary = "Actualiza los detalles de una habitación", Description = "Devuelve los detalles de la habitación actualizada.")]
        [SwaggerResponse(200, "Actualización exitosa.")]
        [SwaggerResponse(404, "La habitación no fue encontrada.")]
        [SwaggerResponse(400, "El modelo no es válido.")]
        public async Task<ActionResult<Room?>> UpdateRoom([FromRoute] int id, [FromBody] RoomDTO RoomDTO)
        {
            if (await RoomServices.CheckExistence(id) == false)
            {
                return NotFound("No se encontró la habitación con ese id.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest("El modelo debe ser válido.");
            }

            var Room = await RoomServices.GetById2(id);
            if (Room == null)
            {
                return NotFound("No se encontró el objeto por su id.");
            }

            // Actualiza las propiedades de la habitación
            Room.Room_number = RoomDTO.Room_number;
            Room.Room_price_per_night = RoomDTO.Room_price_per_night;
            Room.Room_availability = RoomDTO.Room_availability;
            Room.Room_max_occupancy_people = RoomDTO.Room_max_occupancy_people;
            Room.Room_type_id = RoomDTO.Room_type_id;

            await RoomServices.Update(Room);
            return Ok("Se actualizó exitosamente.");
        }
    }
}
