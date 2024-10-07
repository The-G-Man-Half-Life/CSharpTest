using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using CSharpTest.Models;
using CSharpTest.Services;

namespace CSharpTest.Controllers.v1.Guests;

[ApiController]
[Route("api/v1/Guests/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Guests")]
public class GuestGetController : GuestController
{
    public readonly GuestServices GuestServices;

    public GuestGetController(GuestServices GuestServices): base (GuestServices)
    {
        this.GuestServices = GuestServices;
    }

[HttpGet]
public async Task<ActionResult<IEnumerable<Guest>>> GetAll()
{
    var Guests = await GuestServices.GetAll();
    return Ok(Guests);
}

[HttpGet("{id}")]
public async Task<ActionResult<Guest>> GetById([FromRoute] int id)
{
    if (await GuestServices.CheckExistence(id) == false)
    {
        return NoContent();
    }
    else
    {
        var Guest = await GuestServices.GetById(id);
        return Ok(Guest);
    }

}
}