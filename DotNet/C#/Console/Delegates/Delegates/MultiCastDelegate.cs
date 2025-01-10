using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class MultiCastDelegate
    {
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber+secondNumber;
        }

        public int Sub(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public int Mul(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public int Div(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
