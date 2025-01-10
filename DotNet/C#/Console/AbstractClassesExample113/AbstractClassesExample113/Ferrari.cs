using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesExample113
{
    public class Ferrari : Car
    {
        public Ferrari()
        {
            Console.WriteLine("Ferrari Constructor");
        }

        public override void CarColor()
        {
            Console.WriteLine("Red");
        }
    }
}
