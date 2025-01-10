
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertStringIntoCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string str=Console.ReadLine();
            Console.WriteLine("lowercase = "+str.ToLower());
            Console.WriteLine("uppercase "+str.ToUpper());
        }
    }
}
