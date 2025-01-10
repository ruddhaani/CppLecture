using System.ComponentModel.DataAnnotations;
using EMS.Entities;

namespace EMS.Responses.EmployeeResponses
{
    public class EmployeeResponse
    {
        public EmployeeResponse()
        {

        }
        public EmployeeResponse(string name, string email , double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }

        public EmployeeResponse(Employee employee)
        {
            EmployeeId = employee.EmployeeId;
            Name = employee.Name;
            Email = employee.Email;
            Salary = employee.Salary;
        }
        [Key]
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public double Salary { get; set; }
    }
}
