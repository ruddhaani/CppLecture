using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritanceCar
{
    internal class Sports : Car
    {
        public Sports() {
            Console.WriteLine("Sports class");  
        }
        public string Body { get; set; }

        public string Engine { get; set; }

        public string Chassis { get; set; }
    }
}
