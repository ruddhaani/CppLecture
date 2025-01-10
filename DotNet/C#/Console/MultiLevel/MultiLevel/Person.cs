using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevel
{
    public class Person
    {
        public Person() 
        {
            Console.WriteLine("Base class Person constructor called");
        }
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
