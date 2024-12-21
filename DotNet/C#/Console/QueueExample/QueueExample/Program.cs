using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queueObj = new Queue<int>();

            queueObj.Enqueue(1);
            queueObj.Enqueue(2);
            queueObj.Enqueue(3);

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
