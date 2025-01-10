using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3;

namespace add1
{
    internal class Program
    {
        static void Main(string[] args)

        {

           Class1 obj=new Class1();

            Console.WriteLine("Addition of two no " + obj.addition(10, 20));
            Console.WriteLine("Subtraction of two no " + obj.subtraction(10, 20));
            Console.WriteLine("multiplication of two no " + obj.multiplication(10, 20));
            Console.WriteLine("division of two no " + obj.division(10, 20));
            Console.WriteLine("Message"+obj.GetMessage());
        }
    }
}
