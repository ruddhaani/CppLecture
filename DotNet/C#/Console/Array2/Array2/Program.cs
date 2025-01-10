using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;
            if (numbers.Length > 0)
            {
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
            Console.WriteLine(numbers.Length);

            //accessing element by index
            Console.WriteLine($"Element at index 3 is == { numbers[3]}");

            //updating an element
            Console.WriteLine("Extended array elements");
            numbers[1] = 45;
            if (numbers.Length > 0)
            {
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
            



        }
    }
}
