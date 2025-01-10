using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplesof17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print numbers which are divisible by 17");
           
            for(int i=1; i<=100; i++) 
            {
                if (i % 17 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
