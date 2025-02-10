using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample1012
{
    public delegate void ArithmeticDelegate(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithmeticDelegate delegateObj = new ArithmeticDelegate(Arithmetic.Add);
            delegateObj += Arithmetic.Subtract;
            delegateObj += Arithmetic.Multiply;

            delegateObj(10, 2);
        }
    }
}
