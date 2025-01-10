using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorCalling
{
    internal class Employee :Company
    {
        public Employee()
        {
            Console.WriteLine("Derived class Constructor called");
        }

        ~Employee()
        {
            Console.WriteLine("Derived class Destructor called");
        }
    }
}
