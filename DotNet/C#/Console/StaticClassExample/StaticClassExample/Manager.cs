using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassExample
{
    internal class Manager
    {
        public static void Manager1()
        {
            Console.WriteLine(Employee.GetPayroll());
        }
    }
}
