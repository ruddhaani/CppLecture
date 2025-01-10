using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringConcatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string");
            string str1=Console.ReadLine();
            Console.WriteLine("Enter second string");
            string str2=Console.ReadLine();
            Console.WriteLine(string.Concat(str1," ", str2));
        }
    }
}
