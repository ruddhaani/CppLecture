using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructorExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bike bikeObj1 = new Bike("Hunter 350");
            Bike bikeObj2 = new Bike(bikeObj1);

            bikeObj1.displayBikeName();
            bikeObj2.displayBikeName();
        }
    }
}
