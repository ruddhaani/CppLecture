using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample1
{
    delegate void MyEventHandler(string name);
    internal class Publisher
    {
        public event MyEventHandler getMessageEvent;

        public void RaiseEvent(string message)
        {
            getMessageEvent?.Invoke(message);
        }
    }
}
