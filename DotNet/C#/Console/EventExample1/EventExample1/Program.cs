using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisherObj = new Publisher();
            Subscriber subscriberObj = new Subscriber();

            publisherObj.getMessageEvent += subscriberObj.Message;

            MyEventHandler eventHandlerObj = publisherObj.RaiseEvent;

            eventHandlerObj("Subscriber received the message");
        }
    }
}
