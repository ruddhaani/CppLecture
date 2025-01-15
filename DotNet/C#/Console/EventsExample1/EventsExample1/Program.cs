using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();

            Subscriber subscriber1 = new Subscriber("Ani");
            Subscriber subscriber2 = new Subscriber("Snehal");

            publisher.NotifyEvent += subscriber1.OnNotifyEvent;
            publisher.NotifyEvent += subscriber2.OnNotifyEvent;

            publisher.PublishMessage();
        }
    }
}
