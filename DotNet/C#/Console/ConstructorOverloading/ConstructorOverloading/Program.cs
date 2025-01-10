using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person obj= new Person();
            obj.display();

            Person obj2 = new Person("aaa",34);
            obj2.display();

        }
    }
}
