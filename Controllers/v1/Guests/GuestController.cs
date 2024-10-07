using Microsoft.AspNetCore.Mvc;
using CSharpTest.Repositories.Interfaces;
using CSharpTest.Services;

namespace CSharpTest.Controllers.v1.Guests;

[ApiController]
[Route("api/v1/Guests/[controller]")]
[ApiExplorerSettings(GroupName ="v1")]
[Tags("Guests")]
public class GuestController: ControllerBase
{
    protected readonly IGuestRepository GuestRepository;

    public GuestController(IGuestRepository GuestRepository)
    {
        this.GuestRepository = GuestRepository;
    }
}