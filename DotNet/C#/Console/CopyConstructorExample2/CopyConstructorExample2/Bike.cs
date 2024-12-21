using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructorExample2
{
    internal class Bike
    {
        private string name;

        public Bike(string name)
        {
            this.name = name;
        }

        public Bike(Bike bike)
        {
            this.name = bike.name;
        }

        public void displayBikeName()
        {
            Console.WriteLine(name);
        }
    }
}
