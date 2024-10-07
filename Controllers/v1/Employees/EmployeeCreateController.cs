using Microsoft.AspNetCore.Mvc;
using CSharpTest.Models;
using CSharpTest.Services;
using CSharpTest.DTOs.Requests;
using Swashbuckle.AspNetCore.Annotations; // Asegúrate de tener esta referencia

namespace CSharpTest.Controllers.v1.Employees;

[ApiController]
[Route("api/v1/Employees/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Employees")]
public class EmployeeCreateController : EmployeeController
{
    private readonly EmployeeServices EmployeeServices;

    public EmployeeCreateController(EmployeeServices EmployeeServices) : base(EmployeeServices)
    {
        this.EmployeeServices = EmployeeServices;
    }

    /// <summary>
    /// Crea un nuevo empleado.
    /// </summary>
    /// <param name="EmployeeDTO">El DTO del empleado con los datos necesarios.</param>
    /// <returns>Devuelve el nuevo empleado creado.</returns>
    /// <response code="200">Devuelve el empleado creado.</response>
    /// <response code="400">Si el modelo es nulo o inválido.</response>
    [HttpPost]
    [SwaggerOperation(Summary = "Crea un nuevo empleado", Description = "Permite al usuario crear un nuevo empleado.")]
    [SwaggerResponse(200, "Empleado creado exitosamente", typeof(Employee))]
    [SwaggerResponse(400, "El modelo no puede ser nulo o es inválido.")]
    public async Task<IActionResult> CreateNewCarrier([FromBody] EmployeeDTO EmployeeDTO)
    {
        if (ModelState.IsValid == false)
        {
            return BadRequest("The model is bad done");
        }
        else if (EmployeeDTO == null)
        {
            return BadRequest("The model can not be null");
        }
        else
        {
            var newEmployee = new Employee(
                EmployeeDTO.Employee_first_name,
                EmployeeDTO.Employee_last_name,
                EmployeeDTO.Employee_email,
                EmployeeDTO.Employee_identification_number,
                EmployeeDTO.Employee_password
            );
            await EmployeeServices.Add(newEmployee);
            return Ok(newEmployee);
        }
    }
}
