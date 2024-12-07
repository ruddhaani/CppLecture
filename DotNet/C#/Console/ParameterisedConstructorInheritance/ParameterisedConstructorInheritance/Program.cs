using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterisedConstructorInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employeeObj = new Employee(1, "Deloitte", "Very good company");
        }
    }
}
