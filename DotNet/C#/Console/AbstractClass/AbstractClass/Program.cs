﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager managerobj = new Manager();
            Console.WriteLine(managerobj.name());
            Console.WriteLine(managerobj.salary());

           


        }
    }
}
