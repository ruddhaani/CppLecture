using System.ComponentModel.DataAnnotations;
using EmployeeJWTTokenPractice.Dtos;

namespace EmployeeJWTTokenPractice.Entity
{
    public class Employee
    {
        public Employee()
        {

        }

        public Employee(CreateEmployeeDto dto)
        {
            Name = dto.Name;
            Email = dto.Email;
            Salary = dto.Salary;
        }
        [Key]
        public int EmployeeId{ get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public double Salary { get; set; }
    }
}
