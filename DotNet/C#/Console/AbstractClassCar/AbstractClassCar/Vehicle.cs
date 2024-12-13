using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassCar
{
    internal abstract class Vehicle
    {
        public int Wheel()
        {
            return 4;
        }

        abstract public int VehicleId();

    }
}
