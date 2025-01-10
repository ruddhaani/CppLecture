using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat();
            myCat.Speak();
            myCat.Sleep();

            //Cat myCat2 = new Cat();
            //myCat2.Speak();
            //myCat2.Sleep();

        }
    }
}
