using Microsoft.AspNetCore.Mvc;
using CSharpTest.Models;
using CSharpTest.Services;
using CSharpTest.DTOs.Requests;

namespace CSharpTest.Controllers.v1.Employees;

[ApiController]
[Route("api/v1/Employees/[controller]")]
[ApiExplorerSettings(GroupName ="v1")]
[Tags("Employees")]
public class EmployeeCreateController: EmployeeController
{
    private readonly EmployeeServices EmployeeServices;

    public EmployeeCreateController(EmployeeServices EmployeeServices) : base(EmployeeServices)
    {
        this.EmployeeServices = EmployeeServices;
    }

    [HttpPost]
    public async Task<IActionResult> CreateNewCarrier([FromBody]EmployeeDTO EmployeeDTO)
    {
        if(ModelState.IsValid == false)
        {
            return BadRequest("The model is bad done");
        }
        else if(EmployeeDTO == null)
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
