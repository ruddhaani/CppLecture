using System.IdentityModel.Tokens.Jwt;
using EmployeeJWTTokenPractice.Data;
using EmployeeJWTTokenPractice.Dtos;
using EmployeeJWTTokenPractice.Entity;
using EmployeeJWTTokenPractice.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeJWTTokenPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly DataContext _data;
        private readonly JwtService _jwtService;

        public EmployeeController(DataContext data , JwtService jwtService)
        {
            _data = data;
            _jwtService = jwtService;
        }

        [HttpPost]
        public async Task<ActionResult<string>> CreateEmployee(CreateEmployeeDto employeeDto)
        {
            Employee employee = new Employee(employeeDto);

            _data.Employees.Add(employee);

            await _data.SaveChangesAsync();

            string token = _jwtService.CreateEmployee(employee);

            return token;
        }

        [HttpGet("me")]

        public async Task<ActionResult<Employee>> GetEmployeeDetails()
         {
            var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "");

            var claimsPrincipal = _jwtService.ValidateToken(token);

            var id = claimsPrincipal.FindFirst("UserId")?.Value;

            if(string.IsNullOrEmpty(id))
            {
                return Unauthorized("Invalid token.");
            }

            var employee = await _data.Employees.FirstOrDefaultAsync(x => x.EmployeeId == Convert.ToInt32(id));

            return Ok(employee);
        }
    }
}
