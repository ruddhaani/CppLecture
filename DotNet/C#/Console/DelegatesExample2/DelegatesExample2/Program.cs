using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample2
{
    delegate void ArithmeticDelegate(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithmeticDelegate arithmeticDelegate = new ArithmeticDelegate(Arithmetic.Add);
            arithmeticDelegate += Arithmetic.Subtract;
            arithmeticDelegate += Arithmetic.Multiply;

            arithmeticDelegate(10, 2);
        }
    }
}
