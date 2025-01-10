using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueNonGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queueObj = new Queue();
            queueObj.Enqueue(1);
            queueObj.Enqueue(243);
            queueObj.Enqueue("Prajakta");
            queueObj.Enqueue("India");
            if (queueObj.Count > 0)
            {
                foreach (var elements in queueObj)
                {
                    Console.WriteLine(elements);
                }
            } 
            //to remove elements
            queueObj.Dequeue();
            if (queueObj.Count > 0)
            {
                foreach (var elements in queueObj)
                {
                    Console.WriteLine(elements);
                }
            }

        }

    }
}
