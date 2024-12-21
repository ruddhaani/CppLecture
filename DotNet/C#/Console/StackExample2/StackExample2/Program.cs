using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stackObj = new Stack<int>();

            stackObj.Push(10);
            stackObj.Push(20);
            stackObj.Push(30);
            stackObj.Reverse();

            if(stackObj.Count > 0)
            {
                foreach(var item in stackObj)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("The last element inserted is: " + stackObj.Peek());
        }
    }
}
