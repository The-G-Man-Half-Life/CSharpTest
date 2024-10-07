using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSharpTest.Models;
using CSharpTest.Services;
using CSharpTest.DTOs.Requests;

namespace CSharpTest.Controllers.v1.Bookings
{
    [ApiController]
    [Route("api/v1/Bookings/[controller]")]
    [ApiExplorerSettings(GroupName ="v1")]
    [Tags("Bookings")]
    public class BookingGetController : BookingController
    {
        private readonly BookingServices BookingServices;

        public BookingGetController(BookingServices BookingServices) : base(BookingServices)
        {
            this.BookingServices = BookingServices;
        }

        [HttpGet]
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

        [HttpGet("{id}")]
        public async Task<ActionResult<BookingDTO>> GetBookingById([FromRoute]int id)
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
