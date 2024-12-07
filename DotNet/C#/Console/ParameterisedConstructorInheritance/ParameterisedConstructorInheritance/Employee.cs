using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterisedConstructorInheritance
{
    internal class Employee : Company
    {
        public int EmployeeID { get; set; }
        public Employee()
        {
            Console.WriteLine("Employee class");
        }

        public Employee(int employeeID, string name, string description) : base(name, description)
        {
            EmployeeID = employeeID;
            Console.WriteLine(EmployeeID);
        }
    }
}
