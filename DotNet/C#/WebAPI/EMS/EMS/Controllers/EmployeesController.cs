using EMS.Dtos.EmployeeDtos;
using EMS.Entities;
using EMS.Mappings;
using EMS.Params;
using EMS.Responses.EmployeeResponses;
using EMS.Services.EmployeeServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers
{
    public class EmployeesController : BaseApiController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeResponse>> CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            Employee employee = _employeeService.CreateEmployee(createEmployeeDto);
            if(await _employeeService.SaveChangesToDbAsync())
            {
                return Ok(new EmployeeResponse(employee));
            }

            return BadRequest("Failed to create Employee");
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeResponse>>> GetEmployees([FromQuery] EmployeeParams employeeParams)
        {
            var employees = await _employeeService.GetEmployees();

            int skipElements = (employeeParams.PageNumber - 1) * employeeParams.PageSize;

            int takeElements = Math.Min(employees.Count() - skipElements, employeeParams.PageSize);

            // Apply search filter only if SearchText is provided
            if (!string.IsNullOrEmpty(employeeParams.SearchText))
            {
                employees = employees.Where(x =>
                                        x.Name
                                        .Contains(employeeParams.SearchText, StringComparison.OrdinalIgnoreCase));
            }

            int totalCount = employees.Count();

            int totalPages = employees.Count() / employeeParams.PageSize;

            if (employees.Count() % employeeParams.PageSize != 0)
            {
                totalPages++;
            }

            employees = employees.Skip(skipElements).Take(takeElements).ToList();

            Response.Headers.Add("x-Page-Number" , employeeParams.PageNumber.ToString());
            Response.Headers.Add("x-Page-Size", employeeParams.PageSize.ToString());
            Response.Headers.Add("x-Total-Pages", totalPages.ToString());
            Response.Headers.Add("x-Total-Count", totalCount.ToString());

            return Ok(employees);
        }


        [HttpGet("{employeeId:int}")]
        //[Route("{employeeId:int}")]
        public async Task<ActionResult<EmployeeResponse>> GetEmployeeById([FromRoute] int employeeId)
        {
            Employee employee = await _employeeService.GetEmployeeById(employeeId);

            if(employee != null)
            {
                return Ok(new EmployeeResponse(employee));
            }

            return NotFound("Employee Not found");
            
        }

        [HttpDelete("{employeeId:int}")]
        public async Task<ActionResult> DeleteEmployee([FromRoute]int employeeId)
        {
            var employee = await _employeeService.GetEmployeeById(employeeId);
            if(employee == null)
            {
                return BadRequest($"Cannot Delete because Employee Id {employeeId} does not exist.");
            }

            _employeeService.DeleteEmployee(employee);
            if (await _employeeService.SaveChangesToDbAsync())
            {
                return Ok($"Employee with Employee Id {employeeId} is deleted successfully");
            }

            return BadRequest($"Couldn't delete Employee with Employee Id {employeeId}");

        }

        [HttpPut("{employeeId:int}")]
        public async Task<ActionResult> UpdateEmployee(int employeeId , [FromBody] UpdateEmployeeDto updateEmployeeDto)
        {
            var employee = await _employeeService.GetEmployeeById(employeeId);

            if(employee == null)
            {
                return BadRequest($"Cannot Update because Employee Id {employeeId} does not exist.");
            }

            //This is an extension method
            employee.MapUpdateEmployeeDtoWithEmployee(updateEmployeeDto);

            _employeeService.UpdateEmployee(employee);

            if (await _employeeService.SaveChangesToDbAsync())
            {
                return Ok("Updated Successfully");
            }

            return BadRequest("Could Not Find");


        }




    }
}
