using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> obj = new Stack<int>();
            obj.Push(100);
            obj.Push(200);
            obj.Push(300);
            obj.Push(400);

            Console.WriteLine("Stack elements are");
            if (obj.Count > 0)
            {
                foreach (int value in obj)
                {
                    Console.WriteLine(value);
                }

                Console.WriteLine("count is "+obj.Count);
            }
        }
    }
}
