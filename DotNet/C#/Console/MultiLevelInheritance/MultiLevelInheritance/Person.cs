using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    public class Person
    {
        public Person()
        {
            Console.WriteLine("Person Constructor is Called");
        }
        public void Personmessage()
        {
            Console.WriteLine("Hello I am base class");
        }
    }
}
