using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBaseOption
{
    internal class Car
    {
        public Car(int a , int b)
        {
            Console.WriteLine("Parameterized Parent Constructor");
        }
    }

    internal class Ferrari : Car
    {
        public Ferrari(int a , int b) : base(a , b)
        {
            Console.WriteLine("Ferrari Constructor");
        }
    }
}
