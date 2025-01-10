using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructorexample2
{
    internal class Person
    {
        public string name;
        public Person(string name)
        {
            this.name = name;
        }
        public void greet()
        {
            Console.WriteLine("Hello My name is " + name);
        }
    }
}
