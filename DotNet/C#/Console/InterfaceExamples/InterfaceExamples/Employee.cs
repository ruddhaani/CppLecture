using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    internal class Employee : Company
    {
        public string Message()
        {
            return "Hello";
        }

        public void GetMessage()
        {
            Console.WriteLine(Message());
        }
    }
}
