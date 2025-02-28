using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 4, 5, 6, 1, 18, 9, 8, 12 };

            int[] arr1 = arr.Where(n => n % 2 != 0).ToArray();
            int[] arr2 = arr.Where(n => n % 2 == 0).ToArray();

            int[] sortedArray = arr1.Concat(arr2).ToArray();

            Console.Write(string.Join(",", sortedArray));
            




        }
    }
}
