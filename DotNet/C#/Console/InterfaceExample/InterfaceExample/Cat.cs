using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class Cat :IAnimal
    {
        public void speak()
        {
            Console.WriteLine("Cat says Meow Meow");
        }
        public void Eat()
        {
            Console.WriteLine("Cat eats Fish");
        }
    }
}
