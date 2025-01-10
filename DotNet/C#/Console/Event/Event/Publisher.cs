using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public delegate void MyEventHandler(string message);

    public class Publisher
    {
        public event MyEventHandler MyClickEvent;
        
        public void RaseEvent(string message)  
        {
            MyClickEvent?.Invoke(message);
        }
    }
}
