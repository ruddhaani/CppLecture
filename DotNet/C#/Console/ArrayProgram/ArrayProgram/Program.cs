using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            if (numbers.Length != 0)
            {
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
                //new size
                Array.Resize(ref numbers, 15);
                Console.WriteLine("Array size is " + numbers.Length);

                

            }
        }
    }
}
