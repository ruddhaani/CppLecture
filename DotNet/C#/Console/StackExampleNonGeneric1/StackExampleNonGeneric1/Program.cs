using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExampleNonGeneric1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stackObj = new Stack();

            stackObj.Push(10);
            stackObj.Push("Aniruddha");

            if(stackObj.Count > 0)
            {
                foreach (var item in stackObj)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
