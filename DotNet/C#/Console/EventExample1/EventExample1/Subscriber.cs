using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample1
{
    internal class Subscriber
    {
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
