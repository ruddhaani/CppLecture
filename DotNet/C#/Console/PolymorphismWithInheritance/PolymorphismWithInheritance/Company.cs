using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismWithInheritance
{
    internal class Company
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Company() {
            Console.WriteLine("Company Class");
        }

        public Company(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void printName()
        {
            Console.WriteLine(Name);
        }

        public void printDescription()
        {
            Console.WriteLine(Description);
        }
    }
}
