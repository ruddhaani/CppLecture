using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string : ");
            string inp = Console.ReadLine();


            Console.WriteLine("The reversed string is: ");
            for (int i = inp.Length - 1; i >= 0; i--) { 
                Console.Write(inp[i]);
            }

            Console.WriteLine();

        }
    }
}
