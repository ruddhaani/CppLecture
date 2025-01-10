using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassDelegate
{
    delegate void contentDisplay();
    internal class Program
    {
        static void Main(string[] args)
        {
            contentDisplay delObj = Content.Show;
            delObj();

            contentDisplay delObj1 = Content.Display;
            delObj1();

            contentDisplay delObj2 = Content.Print;
            delObj2();

        }
    }
}
