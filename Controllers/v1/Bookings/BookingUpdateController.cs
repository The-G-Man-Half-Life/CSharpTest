using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using CSharpTest.DTOs.Requests;
using CSharpTest.Models;
using CSharpTest.Services;

namespace CSharpTest.Controllers.v1.Bookings
{
    [ApiController]
    [Route("api/v1/Bookings/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Bookings")]
    public class BookingUpdateController : BookingController
    {
        private readonly BookingServices BookingServices;
        private readonly RoomServices RoomServices;

        public BookingUpdateController(BookingServices bookingServices, RoomServices roomServices) : base(bookingServices)
        {
            this.BookingServices = bookingServices;
            this.RoomServices = roomServices;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateBooking([FromRoute] int id, [FromBody] BookingDTO bookingDTO)
        {
            if (!await BookingServices.CheckExistence(id))
            {
                return NotFound("No se encontró ninguna reserva con ese ID.");
            }

            if (bookingDTO == null || !ModelState.IsValid)
            {
                return BadRequest("El modelo debe ser válido.");
            }

            var bookingFound = await BookingServices.GetById2(id);
            if (bookingFound == null)
            {
                return NotFound("No se encontró el objeto por su ID.");
            }

            // Validación de fechas
            if (bookingDTO.Booking_end_date <= bookingDTO.Booking_start_date)
            {
                return BadRequest("La fecha de finalización debe ser mayor que la de inicio.");
            }

            // Obtener la habitación
            var room = await RoomServices.GetById(id);
            if (room == null)
            {
                return BadRequest($"No se encontró la habitación con ID: {bookingDTO.Booking_room_id}");
            }

            // Calcular el costo total
            int daysDifference = (int)(bookingDTO.Booking_end_date - bookingDTO.Booking_start_date).TotalDays;
            double value = id switch
            {
                1 => daysDifference * 50,
                2 => daysDifference * 80,
                3 => daysDifference * 150,
                4 => daysDifference * 200,
                _ => throw new ArgumentException("ID de habitación no válido.")
            };

            // Actualizar el booking
            bookingFound.Booking_start_date = bookingDTO.Booking_start_date;
            bookingFound.Booking_end_date = bookingDTO.Booking_end_date;
            bookingFound.Booking_total_cost = value;
            bookingFound.Booking_room_id = bookingDTO.Booking_room_id;
            bookingFound.Booking_guest_id = bookingDTO.Booking_guest_id;
            bookingFound.Booking_employee_id = bookingDTO.Booking_employee_id;

            await BookingServices.Update(bookingFound);
            return Ok("Se actualizó exitosamente.");
        }
    }
}
