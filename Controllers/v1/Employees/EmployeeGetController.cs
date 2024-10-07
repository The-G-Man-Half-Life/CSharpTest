using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using CSharpTest.Models;
using CSharpTest.Services;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.AspNetCore.Authorization; // Asegúrate de tener esta referencia

namespace CSharpTest.Controllers.v1.Employees;

[ApiController]
[Route("api/v1/Employees/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Employees")]
public class EmployeeGetController : EmployeeController
{
    public readonly EmployeeServices EmployeeServices;

    public EmployeeGetController(EmployeeServices EmployeeServices) : base(EmployeeServices)
    {
        this.EmployeeServices = EmployeeServices;
    }

    /// <summary>
    /// Obtiene todos los empleados.
    /// </summary>
    /// <returns>Una lista de todos los empleados.</returns>
    /// <response code="200">Devuelve una lista de empleados.</response>
    [HttpGet]
    [Authorize]
    [SwaggerOperation(Summary = "Obtiene todos los empleados", Description = "Devuelve una lista de todos los empleados.")]
    [SwaggerResponse(200, "Lista de empleados obtenida exitosamente.", typeof(IEnumerable<Employee>))]
    public async Task<ActionResult<IEnumerable<Employee>>> GetAll()
    {
        var Employees = await EmployeeServices.GetAll();
        return Ok(Employees);
    }

    /// <summary>
    /// Obtiene un empleado por su ID.
    /// </summary>
    /// <param name="id">El ID del empleado a obtener.</param>
    /// <returns>El empleado correspondiente al ID proporcionado.</returns>
    /// <response code="200">Devuelve el empleado encontrado.</response>
    /// <response code="204">Si el empleado no existe.</response>
    [HttpGet("{id}")]
    [Authorize]
    [SwaggerOperation(Summary = "Obtiene un empleado por ID", Description = "Devuelve el empleado correspondiente al ID proporcionado.")]
    [SwaggerResponse(200, "Empleado encontrado.", typeof(Employee))]
    [SwaggerResponse(204, "Empleado no encontrado.")]
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
