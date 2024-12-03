using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Employee
    {
        public Employee() {
            Console.WriteLine("Constructor called.");
        }

        //public Employee(string name)
        //{
        //    Console.WriteLine("This parametirized contrusctor was called by " + name);
        //}

        //Ambiguity code below:

        /*
        public void Message()
        {
            Console.WriteLine();
        }
        */

        public string Message(string name, int age, string age1)
        {
            return "Hello";
        }

        public string Message(string name, string age) {
            return "Something";
        }
    }
}
