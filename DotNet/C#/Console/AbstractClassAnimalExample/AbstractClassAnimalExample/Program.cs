using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAnimalExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dogObj = new Dog();
            dogObj.GetLegs();
            dogObj.Message();
            dogObj.legs = 5;
            Console.WriteLine(dogObj.legs);
        }
    }
}
