using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] array = new int[2] { 10, 20 };
                Console.WriteLine(array[4]);
            }catch(Exception e)
            {
                //Console.WriteLine(e.Message);
                throw e;
            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }
        }
    }
}
