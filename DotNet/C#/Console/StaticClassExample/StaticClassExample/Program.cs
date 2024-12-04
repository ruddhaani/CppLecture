using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Static class example

            Console.WriteLine("Static class example:");
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Logs.Debug("Starting GetEmployee().");
            Console.WriteLine("Employee name: " + Employee.GetEmployee());
            Logs.Debug("Ending GetEmployee().");
            Console.WriteLine();

            Logs.Debug("Starting GetPayroll().");
            Console.WriteLine("Employee salary: " + Employee.GetPayroll());
            Logs.Debug("Ending GetPayroll().");
            Console.WriteLine("------------------------------------------------------------------------------------------");
        }
    }
}
