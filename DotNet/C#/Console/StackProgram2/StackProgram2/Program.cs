
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProgram2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack obj = new Stack();    
            obj.Push(1);
            obj.Push(2);
            obj.Push(67.7);
            obj.Push(4);
            obj.Push(45.6);
            obj.Push('p');
            obj.Push(7);
            obj.Push("pppp");
            obj.Push(9);
            if (obj.Count > 0)
            {
                foreach (var item in obj)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("count is " + obj.Count);
            }
            Console.WriteLine("After deletion ----");
            obj.Pop();
            obj.Pop();
            obj.Pop();
            if (obj.Count > 0)
            {
                foreach (var item in obj)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("count is " + obj.Count);
            }
        }
    }
}
