using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterisedConstructorInheritance
{
    internal class Company
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Company()
        {
            Console.WriteLine("Company class");
        }

        public Company(string name, string description)
        {
            Name = name;
            Description = description;
            Console.WriteLine(Name);
            Console.WriteLine(Description);
        }
    }
}
