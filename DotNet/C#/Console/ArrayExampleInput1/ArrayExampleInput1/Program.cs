using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExampleInput1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array: ");
            int size = Convert.ToInt16(Console.ReadLine());

            int[] arrayObj = new int[size];

            foreach(var item in arrayObj)
            {
                Console.WriteLine(item);
            }

            for(int i = 0; i<size; i++)
            {
                Console.Write($"The element at {i+1} position is: ");
                arrayObj[i] = Convert.ToInt16(Console.ReadLine());
            }

            foreach (var item in arrayObj)
            {
                Console.WriteLine(item);
            }
        }
    }
}
