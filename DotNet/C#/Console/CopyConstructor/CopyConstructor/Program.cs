using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee obj1=new Employee();
            obj1.message();
            Employee obj2=new Employee(obj1);
            Console.ReadLine();
        }
    }
}
