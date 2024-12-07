using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritanceCar
{
    internal class Car
    {
        public Car() {
            Console.WriteLine("Car class");
        }
        public int doors { get; set; }
        public int wheels { get; set; }

        public int window {  get; set; }
    }
}
