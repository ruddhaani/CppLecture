using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleCar
{
    internal class Car : IVehicle
    {
        public int Wheel()
        {
            return 4;
        }

        public int Door()
        {
            return 4;
        }

        public int Windows()
        {
            return 4;
        }

        public void GetDetails()
        {
            Console.WriteLine("A car has " + Door() + " Doors, " + Wheel() + " Wheels and " + Windows() + " Windows.");
        }
    }
}
