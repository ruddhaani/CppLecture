
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisherObj = new Publisher();
            Subscriber subscriberObj = new Subscriber();

            //MyEventHandler delObj = publisherObj.ReceiveMessage;

            MyEventHandler delObj=publisherObj.RaseEvent;
            delObj += subscriberObj.ReceiveMessage;
            delObj("Event triggerd");
            //delObj += subscriberObj.ReceiveMessage;
            //delObj += subscriberObj.ReceiveMessage;
            //delObj -= subscriberObj.ReceiveMessage;
            delObj +=subscriberObj.Message;
            delObj("Hii");


           


        }
    }
}
