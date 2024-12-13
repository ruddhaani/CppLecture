using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Employee
    {
        private Employee()
        {
            Console.WriteLine("Hello");
        }

        static Employee employee;

        public static Employee  CreateObject()
        {
            if(employee == null)
            {
                employee = new Employee();                   
            }
            return employee;
        }

        public static void GetMessage()
        {
            Console.WriteLine("Hello");
        }
    }
}
