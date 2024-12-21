using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = 10;
                int num2 = 10;

                Console.WriteLine(num / num2);

            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }
        }
    }
}
