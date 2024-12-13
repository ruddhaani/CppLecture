using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ferrari ferrariObj = new Ferrari();

            Console.WriteLine("Ferrari has " + ferrariObj.Wheel() + " wheels.");
            Console.WriteLine("The vehicle id of ferrari is " + ferrariObj.VehicleId()); 
        }
    }
}
