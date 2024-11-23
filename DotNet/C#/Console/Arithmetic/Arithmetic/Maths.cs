using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic
{
    public class Maths
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Subtraction(int a, int b) { 
            return a - b; 
        }

        public int Multiplication(int a, int b) {
            return a * b; 
        }

        public int Divide(int a, int b) {
            return a / b; 
        }

        public string GetMessage()
        {
            return "This class is written by aniruddha";
        }
    }
}
