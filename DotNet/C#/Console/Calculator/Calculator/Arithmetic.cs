using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Arithmetic
    {
        public int AddTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public int MultiplyTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public int SubtractTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public int Divide(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
