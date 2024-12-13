using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employeeObj1 = new Employee();
            Employee employeeObj2 = new Employee(employeeObj1);
            Console.WriteLine(employeeObj2.Age);
        }
    }
}
