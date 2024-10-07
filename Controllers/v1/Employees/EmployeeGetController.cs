using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using CSharpTest.Models;
using CSharpTest.Services;

namespace CSharpTest.Controllers.v1.Employees;

[ApiController]
[Route("api/v1/Employees/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Employees")]
public class EmployeeGetController : EmployeeController
{
    public readonly EmployeeServices EmployeeServices;

    public EmployeeGetController(EmployeeServices EmployeeServices): base (EmployeeServices)
    {
        this.EmployeeServices = EmployeeServices;
    }

[HttpGet]
public async Task<ActionResult<IEnumerable<Employee>>> GetAll()
{
    var Employees = await EmployeeServices.GetAll();
    return Ok(Employees);
}

[HttpGet("{id}")]
public async Task<ActionResult<Employee>> GetById([FromRoute] int id)
{
    if (await EmployeeServices.CheckExistence(id) == false)
    {
        return NoContent();
    }
    else
    {
        var Employee = await EmployeeServices.GetById(id);
        return Ok(Employee);
    }

}
}