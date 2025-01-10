using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class Dog :IAnimal
    {
        public void speak()
        {
            Console.WriteLine("Dog says Woof Woof");
        }
        public void Eat()
        {
            Console.WriteLine("Dog eats chicken piece");
        }
    }
}
