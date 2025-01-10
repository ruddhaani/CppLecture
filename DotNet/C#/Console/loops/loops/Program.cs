using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i<=5)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadLine();

            int j = 0;
            do
            {

                Console.WriteLine(j);
                j++;
            } while (j <= 5);

            int value = 0;
            do
            {
                Console.WriteLine(value);
                value++;
            } while (value < 5);

            
        }
    }
}
