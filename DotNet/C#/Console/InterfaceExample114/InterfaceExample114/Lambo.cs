using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample114
{
    internal class Lambo : Vehicle
    {
        public void GetNoOfWheels()
        {
            Console.WriteLine(4);
        }

        public void GetColor()
        {
            Console.WriteLine("RED");
        }
    }
}
