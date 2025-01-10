using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideByZeroException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter number which is divisor of 100");
                int number = Convert.ToInt32(Console.ReadLine());

                int result = 100 / number;
                Console.WriteLine("Result is" + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally block executed");
            }
        }
        
    }
}
