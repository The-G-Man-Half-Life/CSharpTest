using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CSharpTest.Services;

namespace CSharpTest.Controllers.v1.Employees
{
    [ApiController]
    [Route("api/v1/Employees/[controller]")]
    [ApiExplorerSettings(GroupName ="v1")]
    [Tags("Employees")]
    public class EmployeeDeleteController: EmployeeController
    {
        public readonly EmployeeServices EmployeeServices;
        public EmployeeDeleteController(EmployeeServices EmployeeServices): base(EmployeeServices)
        {
            this.EmployeeServices = EmployeeServices;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute]int id)
        {
            if(await EmployeeServices.CheckExistence(id) == false)
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