using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
           GetEmployeeData();
        }
        
        public static void GetEmployeeData()
        {
            Employee employeeObj = new Employee();
            employeeObj.EmployeeID = 1;
            employeeObj.EmployeeName = "Aniruddha";
            employeeObj.EmployeeSalary = 100000;
            employeeObj.UpdatedOn = DateTime.Now;
            employeeObj.CreatedOn = DateTime.UtcNow;

            Console.WriteLine("Employee Name: " + employeeObj.EmployeeName);
            Console.WriteLine("Employee ID: " + employeeObj.EmployeeID);
            Console.WriteLine("Employee Salary: " + employeeObj.EmployeeSalary);
        }
    }
}
