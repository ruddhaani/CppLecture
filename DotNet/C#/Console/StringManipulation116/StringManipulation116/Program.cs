using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation116
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Aniruddha";

            for(int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i]);
            }
            Console.WriteLine();
            
            foreach(var i in name.Reverse())
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
