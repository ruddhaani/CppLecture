using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismWithInheritance
{
    internal class Employee : Company
    {
        public int EmployeeID { get; set; }
        public Employee() {
            Console.WriteLine("Employee");
        }

        public Employee(int id , string name , string description) : base(name , description){
            EmployeeID = id;
        }

        public void printEmployeeID()
        {
            Console.WriteLine(EmployeeID);
        }
    }
}
