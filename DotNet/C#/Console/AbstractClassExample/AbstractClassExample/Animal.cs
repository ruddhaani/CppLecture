using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
     public abstract class Animal
    {
        public abstract void Speak();

        public void Sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }
    }

   
}
