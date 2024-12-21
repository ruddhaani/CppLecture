using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stackObj = new Stack<int>();

            stackObj.Push(1);
            stackObj.Push(2);
            stackObj.Push(3);

            if(stackObj.Count > 0)
            {
                foreach (var item in stackObj)
                {
                    Console.WriteLine(item);
                }
            }

            //for (int i = stackObj.Count; i >= 0; i--)
            //{
            //    Console.WriteLine(stackObj);
            //}
        }
    }
}
