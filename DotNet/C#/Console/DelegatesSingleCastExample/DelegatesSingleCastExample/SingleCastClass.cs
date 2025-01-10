using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesSingleCastExample
{
    public class SingleCastClass
    {
        public void AddNum(int a, int b)
        {
            Console.WriteLine("sum is " + (a + b));
        }

        public static string SayHello(string name)
        {
            return "Hello " + name;
        }
    }
}
