using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car carObj = new Car();
            Bike bikeObj = new Bike();

            carObj.GetDetails();
            Console.WriteLine();

            bikeObj.GetDetails();
        }
    }
}
