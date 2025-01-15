using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample1
{
    internal class Publisher
    {
        public delegate void NotifyEventHandler(object sender, EventArgs e);

        public event NotifyEventHandler NotifyEvent;

        public void PublishMessage()
        {
            Console.WriteLine("Publishing message.....");

            NotifyEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
