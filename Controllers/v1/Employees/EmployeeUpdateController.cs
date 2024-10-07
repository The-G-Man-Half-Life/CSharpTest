using System.Runtime.CompilerServices;
using Bogus.DataSets;
using Microsoft.AspNetCore.Mvc;
using CSharpTest.Models;
using CSharpTest.Repositories.Interfaces;
using CSharpTest.Services;
using CSharpTest.DTOs.Requests;
using Swashbuckle.AspNetCore.Annotations; // Asegúrate de tener esta referencia

namespace CSharpTest.Controllers.v1.Employees;

[ApiController]
[Route("api/v1/Employees/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Employees")]
public class EmployeeUpdateController : EmployeeController
{
    public readonly EmployeeServices EmployeeServices;

    public EmployeeUpdateController(EmployeeServices EmployeeServices) : base(EmployeeServices)
    {
        this.EmployeeServices = EmployeeServices;
    }

    /// <summary>
    /// Actualiza un empleado existente.
    /// </summary>
    /// <param name="id">El ID del empleado a actualizar.</param>
    /// <param name="EmployeeDTO">El DTO del empleado con los nuevos datos.</param>
    /// <returns>Un mensaje de éxito o error.</returns>
    /// <response code="200">Empleado actualizado exitosamente.</response>
    /// <response code="404">Si el empleado no existe o si el modelo no es válido.</response>
    [HttpPut("{id}")]
    [SwaggerOperation(Summary = "Actualiza un empleado existente", Description = "Permite actualizar un empleado por su ID.")]
    [SwaggerResponse(200, "Empleado actualizado exitosamente.")]
    [SwaggerResponse(404, "No se encontró al empleado o el modelo no es válido.")]
    public async Task<IActionResult> update([FromRoute] int id, [FromBody] EmployeeDTO EmployeeDTO)
    {
        if (await EmployeeServices.CheckExistence(id) == false)
        {
            return NotFound("No se encontró a ninguna persona con ese ID.");
        }
        if (ModelState.IsValid == false)
        {
            return NotFound("El modelo debe de ser válido.");
        }
        else
        {
            var foundEmployee = await EmployeeServices.GetById(id);
            foundEmployee.Employee_id = id;
            foundEmployee.Employee_first_name = EmployeeDTO.Employee_first_name;
            foundEmployee.Employee_last_name = EmployeeDTO.Employee_last_name;
            foundEmployee.Employee_email = EmployeeDTO.Employee_email;
            foundEmployee.Employee_identification_number = EmployeeDTO.Employee_identification_number;
            foundEmployee.Employee_password = EmployeeDTO.Employee_password;

            await EmployeeServices.Update(foundEmployee);
            return Ok("Se actualizó exitosamente.");
        }
    }
}
