using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExample3
{
    internal class Developer
    {
    }

    public partial class Employee
    {
        public static void GetProject()
        {
            Console.WriteLine("ABC");
        }
    }
}
