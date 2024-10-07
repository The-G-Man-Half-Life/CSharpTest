using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSharpTest.Repositories.Interfaces;
using CSharpTest.Services;

namespace CSharpTest.Controllers.v1.Bookings;

[ApiController]
[Route("api/v1/Bookings/[controller]")]
[ApiExplorerSettings(GroupName ="v1")]
[Tags("Bookings")]
public class BookingDeleteController: BookingController
{
    private readonly BookingServices BookingServices;

    public BookingDeleteController(BookingServices BookingServices) : base(BookingServices)
    {
        this.BookingServices = BookingServices;
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBooking([FromRoute] int id)
    {
        if(await BookingServices.CheckExistence(id)== false)
        {
            return BadRequest("no existe");
        }
        else
        {
            try
            {
                await BookingServices.Delete(id);
                return Ok("fue un exito");
            }
            catch (DbUpdateException dbEX)
            {
                
                throw new DbUpdateException("un error ocurrio durante el proceso",dbEX);
            }
        }
    }
}