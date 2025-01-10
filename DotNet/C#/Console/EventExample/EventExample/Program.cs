using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisherObj = new Publisher();
            Subscriber subscriberObj = new Subscriber();

            MyEventHandler delObj = publisherObj.Display;
            delObj += subscriberObj.ReceiveMessage;
            delObj();

            MyEventHandler delObj1=publisherObj.Print;
            delObj1 += subscriberObj.ReceiveMessage;
            delObj1();

 

























































        }
    }
}
