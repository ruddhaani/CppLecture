using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExample
{
    partial class Animal
    {
        public string name { get; set; }
        public string type { get; set; }
    }
    partial class Animal
    {
        public void display()
        {
            Console.WriteLine("Animal name " +name+ " " + " type " + type);
        }
    }
}
