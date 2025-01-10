using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class Subscriber
    {
        public void ReceiveMessage(string message)
        {
            Console.WriteLine("Event Message = " + message);
        }
        public void Message(string message) 
        { Console.WriteLine("Second method"); }
    }
}
