using CSharpTest.Config;
using CSharpTest.Data;
using CSharpTest.DTOs.Requests;
using CSharpTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;

namespace CSharpTest.Controllers.v1.auth;
[ApiController]
[Route("api/v1/auth/[controller]")]
public class AuthController : ControllerBase
{
    private readonly ApplicationDbContext Context;
    private readonly Utilities Utilities;

    public AuthController(ApplicationDbContext Context, Utilities Utilities)
    {
        this.Context = Context;
        this.Utilities = Utilities;
    }

    [HttpPost("Register")]
    [SwaggerOperation(
    Summary = "Register a new Employee",
    Description = "This endpoint allows you to register a new Employee in the system"
)]
    [SwaggerResponse(200, "Employee registered successfully")]
    [SwaggerResponse(400, "Wrong Request")]
    [SwaggerResponse(409, "Employee with that identification exists")]

     public async Task<IActionResult> AuthRegister([FromBody] EmployeeDTO Employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Context.Employees.Any(u => u.Employee_identification_number == Employee.Employee_identification_number))
            {
                return Conflict("the Employee already is in the system");
            }

            Employee.Employee_password = Utilities.EncryptSHA256(Employee.Employee_password);

            var NewEmployee = new Employee()
            {
                Employee_first_name = Employee.Employee_first_name,
                Employee_last_name = Employee.Employee_last_name,
                Employee_identification_number = Employee.Employee_identification_number,
                Employee_email = Employee.Employee_email,
                Employee_password = Employee.Employee_password
            };

            await Context.Employees.AddAsync(NewEmployee);
            await Context.SaveChangesAsync();
            return Ok("successfully registered Employee");
        }


        [HttpPost("Login")]
        [SwaggerOperation(
            Summary = "Login into the system",
            Description = "This endpoint allows you to enter the system by using email and password"
        )]
        [SwaggerResponse(200, "Logged in successfully")]
        [SwaggerResponse(401, "Email or password uncorrect")]
        
        public async Task<IActionResult> AuthLogin(EmployeeLogInDTO EmployeeLogin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var EmployeeFound = await Context.Employees.FirstOrDefaultAsync(i => i.Employee_email == EmployeeLogin.Email);
            if (EmployeeFound == null)
            {
                return Unauthorized("Email invalido");
            }

            var passwordvalid = EmployeeFound.Employee_password == Utilities.EncryptSHA256(EmployeeLogin.Password);

            if (passwordvalid == false)
            {
                return Unauthorized("Contraseña invalida");
            }
            var token = Utilities.GenerateJWtToken(EmployeeFound);

            return Ok(token);
        }
}