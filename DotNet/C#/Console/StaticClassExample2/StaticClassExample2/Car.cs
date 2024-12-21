using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassExample2
{
    public static class Car
    {
        public static void CarName(string name)
        {
            Console.WriteLine(name);
        }

        public static void CarWheels(int wheel)
        {
            Console.WriteLine("The car has " + wheel + " wheels.");
        }
    }
}
