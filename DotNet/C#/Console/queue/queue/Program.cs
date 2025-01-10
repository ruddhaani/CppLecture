using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queueObj = new Queue();
            queueObj.Enqueue(1);
            queueObj.Enqueue(2);
            queueObj.Enqueue(3);
            queueObj.Enqueue(4);
            queueObj.Enqueue(5);
            queueObj.Enqueue(6);
            queueObj.Enqueue(7);
            queueObj.Enqueue(8);
            queueObj.Enqueue(9);
            queueObj.Enqueue(10);

            if (queueObj.Count > 0)
            {
                foreach (int item in queueObj)
                {
                    Console.WriteLine(item);
                }

            }
            Console.WriteLine("count is " + queueObj.Count);
            queueObj.Dequeue();
            queueObj.Dequeue();
            queueObj.Dequeue();
            if (queueObj.Count > 0)
            {
                foreach (int item in queueObj)
                {
                    Console.WriteLine(item);
                }

            }
            Console.WriteLine("peek element is "+queueObj.Peek());
            queueObj.Clear();
            if (queueObj.Count == 0) { 
            Console.WriteLine("Queue is clear");
        }
        }
    }
}
