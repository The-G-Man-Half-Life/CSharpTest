using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CSharpTest.Services;

namespace CSharpTest.Controllers.v1.Guests
{
    [ApiController]
    [Route("api/v1/Guests/[controller]")]
    [ApiExplorerSettings(GroupName ="v1")]
    [Tags("Guests")]
    public class GuestDeleteController: GuestController
    {
        public readonly GuestServices GuestServices;
        public GuestDeleteController(GuestServices GuestServices): base(GuestServices)
        {
            this.GuestServices = GuestServices;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute]int id)
        {
            if(await GuestServices.CheckExistence(id) == false)
            {
                return NoContent();
            }
            else
            {
                await GuestServices.Delete(id);
                return Ok("se borro el Guest");
            }
        }
    }
}