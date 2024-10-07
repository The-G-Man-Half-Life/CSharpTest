using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSharpTest.Models;
using CSharpTest.Services;
using CSharpTest.DTOs.Requests;
using Swashbuckle.AspNetCore.Annotations; // Asegúrate de tener esta referencia

namespace CSharpTest.Controllers.v1.Bookings
{
    [ApiController]
    [Route("api/v1/Bookings/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Bookings")]
    public class BookingGetController : BookingController
    {
        private readonly BookingServices BookingServices;

        public BookingGetController(BookingServices BookingServices) : base(BookingServices)
        {
            this.BookingServices = BookingServices;
        }

        /// <summary>
        /// Obtiene todas las reservas.
        /// </summary>
        /// <returns>Una lista de todas las reservas.</returns>
        /// <response code="200">Devuelve una lista de reservas.</response>
        /// <response code="500">Si ocurre un error durante el proceso.</response>
        [HttpGet]
        [SwaggerOperation(Summary = "Obtiene todas las reservas", Description = "Devuelve una lista de todas las reservas.")]
        [SwaggerResponse(200, "Lista de reservas obtenida exitosamente.", typeof(IEnumerable<Booking>))]
        [SwaggerResponse(500, "Un error ocurrió durante el proceso.")]
        public async Task<ActionResult<IEnumerable<Booking>>> GetAll()
        {
            try
            {
                var Bookings = await BookingServices.GetAll();
                return Ok(Bookings);
            }
            catch (DbUpdateException)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Un error ocurrió durante el proceso");
            }
        }

        /// <summary>
        /// Obtiene una reserva por su ID.
        /// </summary>
        /// <param name="id">El ID de la reserva a obtener.</param>
        /// <returns>La reserva correspondiente al ID proporcionado.</returns>
        /// <response code="200">Devuelve la reserva encontrada.</response>
        /// <response code="404">Si la reserva no existe.</response>
        /// <response code="500">Si ocurre un error durante el proceso.</response>
        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Obtiene una reserva por ID", Description = "Devuelve la reserva correspondiente al ID proporcionado.")]
        [SwaggerResponse(200, "Reserva encontrada.", typeof(BookingDTO))]
        [SwaggerResponse(404, "Reserva no encontrada.")]
        [SwaggerResponse(500, "Un error ocurrió durante el proceso.")]
        public async Task<ActionResult<BookingDTO>> GetBookingById([FromRoute] int id)
        {
            if (await BookingServices.CheckExistence(id) == false)
            {
                return NotFound();
            }
            try
            {
                var foundBooking = await BookingServices.GetById(id);
                return Ok(foundBooking);
            }
            catch (DbUpdateException)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Un error ocurrió durante el proceso");
            }
        }
    }
}
