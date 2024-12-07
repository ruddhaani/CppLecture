using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    internal class Employee
    {
        public Employee() {
            Console.WriteLine("Employee class");
        }

        public int EmpID { get; set; }
        public int Salary { get; set; }

    }
}
