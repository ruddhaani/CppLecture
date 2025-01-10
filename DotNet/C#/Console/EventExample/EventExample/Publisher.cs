using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
    public delegate void MyEventHandler();
    public class Publisher
    {
        public event MyEventHandler MyClickEvent;

        public void Display()
        {
            MyClickEvent?.Invoke();
        }

        public void Print()
        {
            MyClickEvent?.Invoke();
        }
    }
}
