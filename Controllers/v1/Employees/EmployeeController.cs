using Microsoft.AspNetCore.Mvc;
using CSharpTest.Repositories.Interfaces;
using CSharpTest.Services;
using CSharpTest.Models;

namespace CSharpTest.Controllers.v1.Employees;

[ApiController]
[Route("api/v1/Employees/[controller]")]
[ApiExplorerSettings(GroupName ="v1")]
[Tags("Employees")]
public class EmployeeController: ControllerBase
{
    protected readonly IEmployeeRepository EmployeeRepository;

    public EmployeeController(IEmployeeRepository EmployeeRepository)
    {
        this.EmployeeRepository = EmployeeRepository;
    }
}