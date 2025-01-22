using BasicCRUDPractice.DTOs;
using BasicCRUDPractice.Entity;
using BasicCRUDPractice.Params;
using BasicCRUDPractice.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicCRUDPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class employeeController : ControllerBase
    {
        private readonly IEmployeeService _service;

        public employeeController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> AddEmployee(CreateEmployeeDto request)
        {
            Employee employee = new Employee(request);

            var emp = _service.AddEmployee(employee);

            if(await _service.SaveChangesToDbAsync())
            {
                return Ok(emp);
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees([FromQuery] EmployeeParams employeeParams)
        {
            var employees = await _service.GetEmployees();

            int skipElements = (employeeParams.PageNumber - 1) * employeeParams.PageSize;

            int takeElement = Math.Min(employees.Count() - skipElements, employeeParams.PageSize);

            if (!string.IsNullOrEmpty(employeeParams.SearchText))
            {
                employees = employees.Where(x =>
                                        x.Name.Contains(employeeParams.SearchText, StringComparison.OrdinalIgnoreCase));
            }

            int totalPages = employees.Count() / employeeParams.PageSize;

            if(employees.Count() % employeeParams.PageSize != 0)
            {
                totalPages++;
            }

            employees = employees.Skip(skipElements).Take(takeElement).ToList();

            Response.Headers.Add("X-Total-Pages", totalPages.ToString());
            Response.Headers.Add("X-Total-Count", employees.Count().ToString());

            return Ok(employees);

        }

        [HttpDelete]
        public async Task<ActionResult> DeleteEmployee([FromQuery]int id)
        {
            var employee = await _service.GetEmployeeById(id);

            if(employee == null)
            {
                return NotFound($"Employee with {id} not found");
            }

            _service.DeleteEmployee(employee);

            if(await _service.SaveChangesToDbAsync())
            {
                return Ok("Deleted");
            }

            return BadRequest();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateEmployee(UpdateEmployeeDto request)
        {
            var employeeOld = await _service.GetEmployeeById(request.EmployeeId);

            if(employeeOld == null)
            {
                return NotFound();
            }

            employeeOld.Department = request.Department;
            employeeOld.Name = request.Name;
            employeeOld.Salary = request.Salary;

            _service.UpdateEmployee(employeeOld);

            if(await _service.SaveChangesToDbAsync())
            {
                return Ok("Updated");
            }

            return BadRequest();
        }
    }
}
