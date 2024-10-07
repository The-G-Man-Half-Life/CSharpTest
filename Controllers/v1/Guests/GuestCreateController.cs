using Microsoft.AspNetCore.Mvc;
using CSharpTest.Models;
using CSharpTest.Services;
using CSharpTest.DTOs.Requests;

namespace CSharpTest.Controllers.v1.Guests;

[ApiController]
[Route("api/v1/Guests/[controller]")]
[ApiExplorerSettings(GroupName ="v1")]
[Tags("Guests")]
public class GuestCreateController: GuestController
{
    private readonly GuestServices GuestServices;

    public GuestCreateController(GuestServices GuestServices) : base(GuestServices)
    {
        this.GuestServices = GuestServices;
    }

    [HttpPost]
    public async Task<IActionResult> CreateNewCarrier([FromBody]GuestDTO GuestDTO)
    {
        if(ModelState.IsValid == false)
        {
            return BadRequest("The model is bad done");
        }
        else if(GuestDTO == null)
        {
            return BadRequest("The model can not be null");
        }
        else
        {
            var newGuest = new Guest(
                GuestDTO.First_name,
                GuestDTO.Last_name,
                GuestDTO.Email,
                GuestDTO.Identification_number,
                GuestDTO.Phone_number,
                GuestDTO.Birthdate
            );
            await GuestServices.Add(newGuest);
            return Ok(newGuest);
        }
    }
}
