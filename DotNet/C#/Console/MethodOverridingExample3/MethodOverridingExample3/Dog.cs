using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingExample3
{
    internal class Dog : Animal
    {
        public override void AnimalClass()
        {
            Console.WriteLine("Child");
        }
    }
}
