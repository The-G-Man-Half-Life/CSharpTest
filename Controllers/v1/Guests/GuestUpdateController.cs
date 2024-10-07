using System.Runtime.CompilerServices;
using Bogus.DataSets;
using Microsoft.AspNetCore.Mvc;
using CSharpTest.Models;
using CSharpTest.Repositories.Interfaces;
using CSharpTest.Services;
using CSharpTest.DTOs.Requests;

namespace CSharpTest.Controllers.v1.Guests;

[ApiController]
[Route("api/v1/Guests/[controller]")]
[ApiExplorerSettings(GroupName ="v1")]
[Tags("Guests")]
public class GuestUpdateController : GuestController
{
    public readonly GuestServices GuestServices;

    public GuestUpdateController(GuestServices GuestServices): base (GuestServices)
    {
        this.GuestServices = GuestServices;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> update([FromRoute] int id,[FromBody]GuestDTO GuestDTO)
    {
        if(await GuestServices.CheckExistence(id)== false)
        {
            return NotFound("No se encontro a ninguna persona con ese id");
        }
        if (ModelState.IsValid == false)
        {
            return NotFound("El modelo debe de ser valido");
        }
        else
        { 
            var foundGuest = await GuestServices.GetById(id);
            foundGuest.Guest_id = id;
            foundGuest.Guest_first_name = GuestDTO.First_name;
            foundGuest.Guest_last_name = GuestDTO.Last_name;
            foundGuest.Guest_email = GuestDTO.Email;
            foundGuest.Guest_identification_number = GuestDTO.Identification_number;
            foundGuest.Guest_phone_number = GuestDTO.Phone_number;
            foundGuest.Guest_birthdate = GuestDTO.Birthdate;
                
            await GuestServices.Update(foundGuest);
            return Ok("se agrego exitosamente");
        }
    }
}