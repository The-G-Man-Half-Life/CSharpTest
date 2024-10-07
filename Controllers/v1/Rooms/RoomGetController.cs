using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSharpTest.Models;
using CSharpTest.Services;
using CSharpTest.DTOs.Requests;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.VisualBasic; // Asegúrate de tener esta referencia

namespace CSharpTest.Controllers.v1.Rooms
{
    [ApiController]
    [Route("api/v1/Rooms/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Rooms")]
    public class RoomGetController : RoomController
    {
        private readonly RoomServices RoomServices;

        public RoomGetController(RoomServices RoomServices) : base(RoomServices)
        {
            this.RoomServices = RoomServices;
        }

        /// <summary>
        /// Obtiene todas las habitaciones.
        /// </summary>
        /// <returns>Lista de habitaciones.</returns>
        /// <response code="200">Operación exitosa.</response>
        /// <response code="500">Error interno del servidor.</response>
        [HttpGet]
        [SwaggerOperation(Summary = "Obtiene todas las habitaciones", Description = "Devuelve una lista de todas las habitaciones disponibles.")]
        [SwaggerResponse(200, "Operación exitosa.")]
        [SwaggerResponse(500, "Error interno del servidor.")]
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

        /// <summary>
        /// Obtiene una habitación por su ID.
        /// </summary>
        /// <param name="id">ID de la habitación a buscar.</param>
        /// <returns>Detalles de la habitación.</returns>
        /// <response code="200">Operación exitosa.</response>
        /// <response code="404">La habitación no fue encontrada.</response>
        /// <response code="500">Error interno del servidor.</response>
        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Obtiene una habitación por su ID", Description = "Devuelve los detalles de una habitación específica.")]
        [SwaggerResponse(200, "Operación exitosa.")]
        [SwaggerResponse(404, "La habitación no fue encontrada.")]
        [SwaggerResponse(500, "Error interno del servidor.")]
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

        /// <summary>
        /// Obtiene todas las habitaciones libres.
        /// </summary>
        /// <returns>Lista de habitaciones libres.</returns>
        /// <response code="200">Operación exitosa.</response>
        /// <response code="500">Error interno del servidor.</response>
        [HttpGet("/FreeRooms")]
        [SwaggerOperation(Summary = "Obtiene todas las habitaciones que estan libres", Description = "Devuelve una lista de todas las habitaciones disponibles.")]
        [SwaggerResponse(200, "Operación exitosa.")]
        [SwaggerResponse(500, "Error interno del servidor.")]
        public async Task<ActionResult<IEnumerable<Room>>> GetAllFreeRooms()
        {
            try
            {
                var Rooms = await RoomServices.GetAll();
                var FreeRooms = Rooms.Where(r=>r.Room_availability==true);
                return Ok(Rooms);
            }
            catch (DbUpdateException)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Un error ocurrió durante el proceso");
            }
        }

        /// <summary>
        /// Obtiene todas las habitaciones.
        /// </summary>
        /// <returns>Lista de habitaciones.</returns>
        /// <response code="200">Operación exitosa.</response>
        /// <response code="500">Error interno del servidor.</response>
        [HttpGet("/FreeOccupiedRooms")]
        [SwaggerOperation(Summary = "Obtiene una cuenta de todas las habitaciones ocupadas y libres", Description = "Devuelve una lista indicando el total de habitaciones libres y ocupadas")]
        [SwaggerResponse(200, "Operación exitosa.")]
        [SwaggerResponse(500, "Error interno del servidor.")]
        public async Task<ActionResult<IEnumerable<Object>>> ListOfFreeBusyRooms()
        {
            try
            {
                var Rooms = await RoomServices.GetAll();
                var totalFreeRooms = Rooms.Count(r=>r.Room_availability == true);
                var totalOccupiedRooms = Rooms.Count(r=>r.Room_availability == false);
                var BusyFreeRooms = Rooms
                .Select(s=> new {
                    occupied = totalOccupiedRooms,
                    free = totalFreeRooms
                });
                return Ok(BusyFreeRooms.First());
            }
            catch (DbUpdateException)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Un error ocurrió durante el proceso");
            }
        }

                /// <summary>
        /// Obtiene todas las habitaciones ocupadas.
        /// </summary>
        /// <returns>Lista de habitaciones.</returns>
        /// <response code="200">Operación exitosa.</response>
        /// <response code="500">Error interno del servidor.</response>
        [HttpGet("/OccupiedRooms")]
        [SwaggerOperation(Summary = "Obtiene una cuenta de todas las habitaciones ocupadas", Description = "Devuelve una lista con las habitaciones ocupadas")]
        [SwaggerResponse(200, "Operación exitosa.")]
        [SwaggerResponse(500, "Error interno del servidor.")]
        public async Task<ActionResult<IEnumerable<Object>>> ListOfBusyRooms()
        {
            try
            {
                var Rooms = await RoomServices.GetAll();
                var OccupiedRooms = Rooms.Where(r=>r.Room_availability==false).ToList();
                return Ok(OccupiedRooms);
            }
            catch (DbUpdateException)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Un error ocurrió durante el proceso");
            }
        }
    }
}
