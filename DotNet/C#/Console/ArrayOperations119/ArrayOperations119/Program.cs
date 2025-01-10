using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperations119
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            
            Console.WriteLine("----------------------------------------READING ARRAY----------------------------------------------");
            for (int i = 0; i <array.Length; i++)
            {
                int num = Convert.ToInt16(Console.ReadLine());
                array[i] = num;
            }

            Console.WriteLine("----------------------------------------PRINTING ARRAY----------------------------------------------");
            foreach(var i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
