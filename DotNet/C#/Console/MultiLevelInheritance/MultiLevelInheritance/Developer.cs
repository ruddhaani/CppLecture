﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    internal class Developer : Employee
    {
        public string Team {  get; set; }
        public string Project { get; set; }
    }
}
