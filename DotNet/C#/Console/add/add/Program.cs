using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace add
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cal obj = new Cal();  //here we accessed this class from class library
            //obj.GetMessage();
            //obj.Addition(10,20);
            Console.WriteLine("Addition of two number " + obj.Addition(10, 20));
            Console.WriteLine("Function Message " + obj.GetMessage());
            Console.ReadLine();

            

        }
    }
}
