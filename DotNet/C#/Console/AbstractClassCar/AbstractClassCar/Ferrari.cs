using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassCar
{
    internal class Ferrari : Vehicle
    {
        public override int VehicleId()
        {
            return 1121;
        }

        public new int Wheel()
        {
            return 5;
        }
    }
}
