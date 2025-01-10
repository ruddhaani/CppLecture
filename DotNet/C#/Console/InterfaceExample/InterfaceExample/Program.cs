using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal DogObj = new Dog();
            IAnimal CatObj= new Cat();

            DogObj.speak();
            DogObj.Eat();

            CatObj.Eat();
            CatObj.speak();
        }
    }
}
