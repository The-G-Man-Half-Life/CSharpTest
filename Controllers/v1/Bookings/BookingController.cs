using Microsoft.AspNetCore.Mvc;
using CSharpTest.Repositories.Interfaces;

namespace CSharpTest.Controllers.v1.Bookings;

[ApiController]
[Route("api/v1/Bookings/[controller]")]
[ApiExplorerSettings(GroupName ="v1")]
[Tags("Bookings")]
public class BookingController: ControllerBase
{
    protected readonly IBookingRepository BookingRepository;

    public BookingController(IBookingRepository BookingRepository)
    {
        this.BookingRepository = BookingRepository;
    }
}