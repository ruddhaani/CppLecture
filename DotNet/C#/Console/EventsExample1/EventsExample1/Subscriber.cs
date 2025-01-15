using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample1
{
    internal class Subscriber
    {
        private string _name;
        public Subscriber()
        {

        }

        public Subscriber(string name)
        {
            _name = name;
        }

        public void OnNotifyEvent(object sender , EventArgs e)
        {
            Console.WriteLine($"{_name} : Receving message ..............");
        }
    }
}
