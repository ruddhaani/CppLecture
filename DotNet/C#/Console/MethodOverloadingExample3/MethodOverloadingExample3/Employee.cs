using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExample3
{
    internal class Employee
    {
        public static void GetSalary(double  salary , double bonus)
        {
            Console.WriteLine(salary + bonus);
        }

        public static void GetSalary(double salary)
        {
            Console.WriteLine(salary);
        }
    }
}
