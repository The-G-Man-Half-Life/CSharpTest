using Microsoft.AspNetCore.Mvc;
using CSharpTest.Models;
using CSharpTest.Services;
using CSharpTest.DTOs.Requests;
using Swashbuckle.AspNetCore.Annotations; // Asegúrate de tener esta referencia

namespace CSharpTest.Controllers.v1.Guests;

[ApiController]
[Route("api/v1/Guests/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Guests")]
public class GuestCreateController : GuestController
{
    private readonly GuestServices GuestServices;

    public GuestCreateController(GuestServices GuestServices) : base(GuestServices)
    {
        this.GuestServices = GuestServices;
    }

    /// <summary>
    /// Crea un nuevo huésped.
    /// </summary>
    /// <param name="GuestDTO">El DTO del huésped con los datos necesarios.</param>
    /// <returns>Devuelve el nuevo huésped creado.</returns>
    /// <response code="200">Devuelve el huésped creado.</response>
    /// <response code="400">Si el modelo es nulo o inválido.</response>
    [HttpPost]
    [SwaggerOperation(Summary = "Crea un nuevo huésped", Description = "Permite al usuario crear un nuevo huésped.")]
    [SwaggerResponse(200, "Huésped creado exitosamente", typeof(Guest))]
    [SwaggerResponse(400, "El modelo no puede ser nulo o es inválido.")]
    public async Task<IActionResult> CreateNewCarrier([FromBody] GuestDTO GuestDTO)
    {
        if (ModelState.IsValid == false)
        {
            return BadRequest("The model is bad done");
        }
        else if (GuestDTO == null)
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
