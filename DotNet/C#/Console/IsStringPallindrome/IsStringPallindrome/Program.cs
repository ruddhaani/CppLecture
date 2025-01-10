using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsStringPallindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str=Console.ReadLine();
            Console.WriteLine(str == new string(str.Reverse().ToArray()) ? "Pallindrome" : "Not pallindrome");


        }
    }
}
