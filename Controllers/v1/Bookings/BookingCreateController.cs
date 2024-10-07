using Microsoft.AspNetCore.Mvc;
using CSharpTest.DTOs.Requests;
using CSharpTest.Models;
using CSharpTest.Services;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.AspNetCore.Authorization; // Asegúrate de tener esta referencia

namespace CSharpTest.Controllers.v1.Bookings
{
    [ApiController]
    [Route("api/v1/Bookings/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Bookings")]
    public class BookingCreateController : BookingController
    {
        private readonly BookingServices BookingServices;
        private readonly RoomServices RoomServices;

        public BookingCreateController(BookingServices bookingServices, RoomServices roomServices) : base(bookingServices)
        {
            this.BookingServices = bookingServices;
            this.RoomServices = roomServices;
        }

        /// <summary>
        /// Crea una nueva reserva.
        /// </summary>
        /// <param name="bookingDTO">El DTO de la reserva que contiene los datos necesarios.</param>
        /// <returns>Devuelve la nueva reserva creada.</returns>
        /// <response code="200">Devuelve la reserva creada.</response>
        /// <response code="400">Si el modelo es nulo o inválido.</response>
        [HttpPost]
        [Authorize]
        [SwaggerOperation(Summary = "Crea una nueva reserva", Description = "Permite al usuario crear una nueva reserva.")]
        [SwaggerResponse(200, "Reserva creada exitosamente", typeof(Booking))]
        [SwaggerResponse(400, "El modelo no puede ser nulo o es inválido.")]
        public async Task<IActionResult> CreateNewBooking([FromBody] BookingDTO bookingDTO)
        {
            if (bookingDTO == null)
            {
                return BadRequest("El modelo no puede ser nulo.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest("El modelo es inválido.");
            }

            var roomfound = await BookingServices.GetAll();
            var room = roomfound.Count() + 1;

            int daysDifference = (int)(bookingDTO.Booking_end_date - bookingDTO.Booking_start_date).TotalDays;
            double value = 0;
            if (room == 1)
            {
                value = daysDifference * 50;
            }
            else if (room == 2)
            {
                value = daysDifference * 80;
            }
            else if (room == 3)
            {
                value = daysDifference * 150;
            }
            else if (room == 4)
            {
                value = daysDifference * 200;
            }

            var newBooking = new Booking(
                bookingDTO.Booking_start_date,
                bookingDTO.Booking_end_date,
                bookingDTO.Booking_total_cost = value,
                bookingDTO.Booking_room_id,
                bookingDTO.Booking_guest_id,
                bookingDTO.Booking_employee_id
            );

            await BookingServices.Add(newBooking);
            return Ok(newBooking);
        }
    }
}
