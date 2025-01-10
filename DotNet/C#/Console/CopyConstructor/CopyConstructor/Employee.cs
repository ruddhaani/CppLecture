using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Constructor");
        }
        public void message()
        {
            Console.WriteLine("Hello");
        }

        public Employee(Employee obj1)
        {
            Console.WriteLine("object one copy into second object");
            message();
        }
    }
}
