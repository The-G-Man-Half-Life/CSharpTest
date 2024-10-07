using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CSharpTest.Services;
using Swashbuckle.AspNetCore.Annotations; // Asegúrate de tener esta referencia

namespace CSharpTest.Controllers.v1.Guests
{
    [ApiController]
    [Route("api/v1/Guests/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Guests")]
    public class GuestDeleteController : GuestController
    {
        public readonly GuestServices GuestServices;

        public GuestDeleteController(GuestServices GuestServices) : base(GuestServices)
        {
            this.GuestServices = GuestServices;
        }

        /// <summary>
        /// Elimina un huésped existente.
        /// </summary>
        /// <param name="id">El ID del huésped que se desea eliminar.</param>
        /// <returns>Un mensaje de éxito o error.</returns>
        /// <response code="200">Huésped eliminado exitosamente.</response>
        /// <response code="204">Si el huésped no existe.</response>
        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = "Elimina un huésped existente", Description = "Permite eliminar un huésped por su ID.")]
        [SwaggerResponse(200, "Huésped eliminado exitosamente.")]
        [SwaggerResponse(204, "No se encontró el huésped.")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (await GuestServices.CheckExistence(id) == false)
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
