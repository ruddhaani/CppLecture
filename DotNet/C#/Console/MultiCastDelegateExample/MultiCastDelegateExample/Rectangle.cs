using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegateExample
{
    public class Rectangle
    {
        public void GetArea(double width, double height)
        {
            Console.WriteLine("Area is "+width * height);
        }

        public void Getperimeter(double width, double height)
        {
            Console.WriteLine("Parameter is " + (2 * (width + height)));
        }
    }
}
