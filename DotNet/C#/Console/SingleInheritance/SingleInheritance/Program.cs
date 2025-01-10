using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student studentObj = new student();
            studentObj.Learn();
            studentObj.Teach();
        }
    }
}
