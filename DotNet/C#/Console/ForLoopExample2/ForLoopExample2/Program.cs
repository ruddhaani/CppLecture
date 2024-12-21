using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd numbers between 0 & 20");

            for(int i = 1; i<20; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
