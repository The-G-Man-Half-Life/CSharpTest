using System.Runtime.CompilerServices;
using Bogus.DataSets;
using Microsoft.AspNetCore.Mvc;
using CSharpTest.Models;
using CSharpTest.Repositories.Interfaces;
using CSharpTest.Services;
using CSharpTest.DTOs.Requests;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.AspNetCore.Authorization; // Asegúrate de tener esta referencia

namespace CSharpTest.Controllers.v1.Guests;

[ApiController]
[Route("api/v1/Guests/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Guests")]
public class GuestUpdateController : GuestController
{
    public readonly GuestServices GuestServices;

    public GuestUpdateController(GuestServices GuestServices) : base(GuestServices)
    {
        this.GuestServices = GuestServices;
    }

    /// <summary>
    /// Actualiza un huésped existente.
    /// </summary>
    /// <param name="id">El ID del huésped a actualizar.</param>
    /// <param name="GuestDTO">El DTO del huésped con los nuevos datos.</param>
    /// <returns>Un mensaje de éxito o error.</returns>
    /// <response code="200">Huésped actualizado exitosamente.</response>
    /// <response code="404">Si el huésped no existe o si el modelo no es válido.</response>
    [HttpPut("{id}")]
    [Authorize]
    [SwaggerOperation(Summary = "Actualiza un huésped existente", Description = "Permite actualizar un huésped por su ID.")]
    [SwaggerResponse(200, "Huésped actualizado exitosamente.")]
    [SwaggerResponse(404, "No se encontró el huésped o el modelo no es válido.")]
    public async Task<IActionResult> update([FromRoute] int id, [FromBody] GuestDTO GuestDTO)
    {
        if (await GuestServices.CheckExistence(id) == false)
        {
            return NotFound("No se encontró a ninguna persona con ese ID.");
        }
        if (ModelState.IsValid == false)
        {
            return NotFound("El modelo debe de ser válido.");
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
            return Ok("Se actualizó exitosamente.");
        }
    }
}
