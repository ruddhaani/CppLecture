﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.WriteLine(employee.Message("Aniruddha", 18 , "Again"));

            Console.WriteLine(employee.Message("Aniruddha", "New"));
        }
    }
}