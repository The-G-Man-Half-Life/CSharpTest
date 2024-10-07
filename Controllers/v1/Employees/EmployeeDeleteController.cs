using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CSharpTest.Services;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.AspNetCore.Authorization; // Asegúrate de tener esta referencia

namespace CSharpTest.Controllers.v1.Employees
{
    [ApiController]
    [Route("api/v1/Employees/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Employees")]
    public class EmployeeDeleteController : EmployeeController
    {
        public readonly EmployeeServices EmployeeServices;

        public EmployeeDeleteController(EmployeeServices EmployeeServices) : base(EmployeeServices)
        {
            this.EmployeeServices = EmployeeServices;
        }

        /// <summary>
        /// Elimina un empleado existente.
        /// </summary>
        /// <param name="id">El ID del empleado que se desea eliminar.</param>
        /// <returns>Un mensaje de éxito o error.</returns>
        /// <response code="200">Empleado eliminado exitosamente.</response>
        /// <response code="204">Si el empleado no existe.</response>
        [HttpDelete("{id}")]
        [Authorize]
        [SwaggerOperation(Summary = "Elimina un empleado existente", Description = "Permite eliminar un empleado por su ID.")]
        [SwaggerResponse(200, "Empleado eliminado exitosamente.")]
        [SwaggerResponse(204, "No se encontró el empleado.")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (await EmployeeServices.CheckExistence(id) == false)
            {
                return NoContent();
            }
            else
            {
                await EmployeeServices.Delete(id);
                return Ok("se borro el Employee");
            }
        }
    }
}
