﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
    public class Subscriber
    {
        public void ReceiveMessage()
        {
            Console.WriteLine("Event Message triggered" );
        }
    }
}
