using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterSetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person obj = new Person();
            obj.Name = "Prajakta";
            obj.Age = 25;
            Console.WriteLine("name is "+obj.Name);
            Console.WriteLine("age is "+obj.Age);
        }
    }
}
