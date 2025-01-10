using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesign
{
    public  class Employee
    {
        static Employee()
        {
            Console.WriteLine("Constructor called");
        }

        public static void message()
        {
            Console.WriteLine("Hello");
        }
        public static  void GetEmployee()
        {
            Console.WriteLine("Prajakta");
        }
    }
}
