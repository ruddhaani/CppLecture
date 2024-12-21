using System;
using System.Collections;

namespace QueueExampleNonGeneric1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queueObj = new Queue();

            queueObj.Enqueue(10);
            queueObj.Enqueue("Aniruddha");

            if(queueObj.Count > 0)
            {
                foreach (var item in queueObj)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
