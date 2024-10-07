using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSharpTest.Repositories.Interfaces;
using CSharpTest.Services;
using Swashbuckle.AspNetCore.Annotations; // Asegúrate de tener esta referencia

namespace CSharpTest.Controllers.v1.Bookings;

[ApiController]
[Route("api/v1/Bookings/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Bookings")]
public class BookingDeleteController : BookingController
{
    private readonly BookingServices BookingServices;

    public BookingDeleteController(BookingServices BookingServices) : base(BookingServices)
    {
        this.BookingServices = BookingServices;
    }

    /// <summary>
    /// Elimina una reserva existente.
    /// </summary>
    /// <param name="id">El ID de la reserva que se desea eliminar.</param>
    /// <returns>Un mensaje de éxito o error.</returns>
    /// <response code="200">Reserva eliminada exitosamente.</response>
    /// <response code="400">Si la reserva no existe.</response>
    [HttpDelete("{id}")]
    [SwaggerOperation(Summary = "Elimina una reserva existente", Description = "Permite eliminar una reserva por su ID.")]
    [SwaggerResponse(200, "Reserva eliminada exitosamente.")]
    [SwaggerResponse(400, "La reserva no existe.")]
    public async Task<IActionResult> DeleteBooking([FromRoute] int id)
    {
        if (await BookingServices.CheckExistence(id) == false)
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
                throw new DbUpdateException("un error ocurrio durante el proceso", dbEX);
            }
        }
    }
}
