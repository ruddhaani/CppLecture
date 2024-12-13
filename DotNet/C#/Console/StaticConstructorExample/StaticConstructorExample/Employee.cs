using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructorExample
{
    internal static class Employee
    {
        static Employee()
        {
            Console.WriteLine("Employee Class Const");
        }

        public static void GetName()
        {
            Console.WriteLine("Ani");
        }

        public static void GetMessage()
        {
            Console.WriteLine("Message");
        }
    }
}
