using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesExample113
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ferrari ferrari = new Ferrari();

            ferrari.CarColor();
            ferrari.PrintNoOfWheels();
        }
    }
}
