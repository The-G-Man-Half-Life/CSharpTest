using System.Runtime.CompilerServices;
using Bogus.DataSets;
using Microsoft.AspNetCore.Mvc;
using CSharpTest.Models;
using CSharpTest.Repositories.Interfaces;
using CSharpTest.Services;
using CSharpTest.DTOs.Requests;

namespace CSharpTest.Controllers.v1.Employees;

[ApiController]
[Route("api/v1/Employees/[controller]")]
[ApiExplorerSettings(GroupName ="v1")]
[Tags("Employees")]
public class EmployeeUpdateController : EmployeeController
{
    public readonly EmployeeServices EmployeeServices;

    public EmployeeUpdateController(EmployeeServices EmployeeServices): base (EmployeeServices)
    {
        this.EmployeeServices = EmployeeServices;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> update([FromRoute] int id,[FromBody]EmployeeDTO EmployeeDTO)
    {
        if(await EmployeeServices.CheckExistence(id)== false)
        {
            return NotFound("No se encontro a ninguna persona con ese id");
        }
        if (ModelState.IsValid == false)
        {
            return NotFound("El modelo debe de ser valido");
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
            return Ok("se agrego exitosamente");
        }
    }
}