using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //one instance of static class is created in the memory.
            Employee.GetMessage();
            Employee.GetName();
        }
    }
}
