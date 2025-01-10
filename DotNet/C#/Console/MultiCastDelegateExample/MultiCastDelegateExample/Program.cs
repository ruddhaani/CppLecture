using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegateExample
{
    public delegate void RectangleDelegate(double width, double height);
    internal class Program
    {
        static void Main(string[] args)
        {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
            Rectangle obj = new Rectangle();
            RectangleDelegate delObj = new RectangleDelegate(obj.Getperimeter);
            //or RectangleDelegate delObj=obj.GetPerimeter;
            delObj += obj.GetArea;
            delObj(3.0, 2.5);



        }
    }
}
