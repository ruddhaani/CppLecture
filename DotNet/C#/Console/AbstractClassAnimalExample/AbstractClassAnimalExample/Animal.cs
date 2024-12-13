using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAnimalExample
{
    internal abstract class Animal
    {

        //Abstract classes can have constructors.
        public Animal()
        {
            Console.WriteLine("Animal Class Constructor");
        }
        public int legs { get; set; }

        public void Message()
        {
            Console.WriteLine("This is a message from Animal Class");
        }

        public abstract void GetLegs();
    }
}
