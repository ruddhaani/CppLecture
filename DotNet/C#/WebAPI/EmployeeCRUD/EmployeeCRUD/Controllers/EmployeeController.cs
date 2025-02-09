using EmployeeCRUD.DTOs.EmployeeDTOs;
using EmployeeCRUD.Entities;
using EmployeeCRUD.Mappings;
using EmployeeCRUD.Params;
using EmployeeCRUD.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace EmployeeCRUD.Controllers
{
    
    public class EmployeeController : BaseAPIController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> CreateEmployee(CreateEmployeeDTO employeeDTO)
        {
            var employee = _employeeService.Create(new Employee(employeeDTO));

            if (await _employeeService.SaveChangesToDbAsync())
            {
                return Ok(employee);
            }

            return BadRequest("Not created");
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees([FromQuery] EmployeeParams employeeParams)
        {
            var employees = await _employeeService.GetEmployees();

            int skipElements = (employeeParams.PageNumber - 1) * employeeParams.PageSize;
            int takeElements = Math.Min(employees.Count() - skipElements , employeeParams.PageSize);

            if (!string.IsNullOrEmpty(employeeParams.SearchText))
            {
                employees = employees.Where(emp => emp.Name.Contains(employeeParams.SearchText, StringComparison.OrdinalIgnoreCase));
            }

            int totalPages = employees.Count() / employeeParams.PageSize;

            if(employees.Count() % employeeParams.PageSize != 0)
            {
                totalPages++;
            }

            Response.Headers.Add("X-Total-Pages", totalPages.ToString());
            Response.Headers.Add("X-Total-Count", employees.Count().ToString());

            employees = employees.Skip(skipElements).Take(takeElements).ToList();

            

            return Ok(employees);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteEmployeee(int id)
        {
            var employee = await _employeeService.GetEmployeeById(id);

            if (employee == null)
            {
                return NotFound();
            }

            _employeeService.Delete(employee);

            if (await _employeeService.SaveChangesToDbAsync())
            {
                return Ok($"Employee with id : {id} is deleted");
            }

            return BadRequest();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateEmployee(int id , [FromBody]UpdateEmployeeDTO updateEmployee)
        {
            Employee employee = await _employeeService.GetEmployeeById(id);

            if(employee == null)
            {
                return NotFound();
            }

            employee.MapUpdateEmployeeDTOWithEmployee(updateEmployee);

            _employeeService.Update(employee);

            if(await _employeeService.SaveChangesToDbAsync())
            {
                return Ok($"Updated the employee with employee id : {id}");
            }

            return BadRequest();
        }
    }
}
