using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryExample01;

namespace LibExample02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arithmetic obj = new Arithmetic();

            Console.WriteLine(obj.Addition(1,2));
            Console.WriteLine(obj.Multiplication(2,3));
            Console.WriteLine(obj.Subtraction(2,1));
            Console.WriteLine(obj.Divide(22,4));
            Console.WriteLine(obj.GetMessage());
        }
    }
}
