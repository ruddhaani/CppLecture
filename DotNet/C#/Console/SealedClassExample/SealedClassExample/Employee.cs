﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassExample
{
    internal class Employee : AuditEntity
    {
        public Employee() {
            Console.WriteLine("Employee class.");
        }
    }
}
