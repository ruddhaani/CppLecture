using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                int num1 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter another number: ");
                int num2 = Convert.ToInt16(Console.ReadLine());
                int num3 = num1 / num2;
                Console.WriteLine(num3);
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }
        }
    }
}
