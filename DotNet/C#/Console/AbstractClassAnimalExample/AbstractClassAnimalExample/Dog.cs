using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAnimalExample
{
    internal class Dog : Animal
    {
        public override void GetLegs()
        {
            Console.WriteLine("Dog has four legs");
        }
    }
}
