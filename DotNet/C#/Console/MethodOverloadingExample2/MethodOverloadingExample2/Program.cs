using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator.Add(1, 2);
            Calculator.Add(1 , 2, 3);
        }
    }
}
