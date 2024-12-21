using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructorExample2
{
    public static class Employee
    {
        static Employee()
        {
            Console.WriteLine("This is employee class constructor");
        }

        public static void GetEmpName(string name)
        {
            Console.WriteLine("The employee name is " + name);
        }
    }
}
