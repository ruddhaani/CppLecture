using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesExample113
{
    public abstract class Car
    {
        public Car()
        {
            Console.WriteLine("Car Class Constructor");
        }

        public abstract void CarColor();

        public void PrintNoOfWheels()
        {
            Console.WriteLine(4);
        }
    }
}
