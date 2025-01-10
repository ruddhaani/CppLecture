using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueProgram2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue obj = new Queue();
            obj.Enqueue(455);
            obj.Enqueue("KKKK");
            obj.Enqueue("rrrr");
            obj.Enqueue(467.7);
            obj.Enqueue(5);
            if (obj.Count > 0)
            {
                foreach (var item in obj)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("count is " + obj.Count);
            }
            obj.Peek();
            Console.WriteLine("elements at peek is"+obj.Peek());

            obj.Dequeue();
            obj.Dequeue();
            obj.Dequeue();
            Console.WriteLine("After deletion ---");
            if (obj.Count > 0)
            {
                foreach (var item in obj)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("count is " + obj.Count);
            }
            obj.Peek();
            Console.WriteLine("elements at peek is" + obj.Peek());
        }

    }
}
