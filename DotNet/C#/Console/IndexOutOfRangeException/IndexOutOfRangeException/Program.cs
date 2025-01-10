using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOutOfRangeException
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int[] numbers = { 1, 2, 3, 4, 5, };
                Console.WriteLine("Array elements");

                for (int i = 0; i <= numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception message" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }
        }
    }
}
