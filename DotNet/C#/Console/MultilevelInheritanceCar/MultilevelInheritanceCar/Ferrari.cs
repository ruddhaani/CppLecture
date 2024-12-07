using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritanceCar
{
    internal class Ferrari : Sports
    {
        public Ferrari()
        {
            Console.WriteLine("Ferrari.");
        }
        public string Color { get; set; }
        
        public float TopSpeed { get; set; }

        public string ModelNumber { get; set; }
    }
}
