using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class Class1
    {
        public int addition(int firstNumber, int secondNumber) {
            return firstNumber + secondNumber;
        }
        public int subtraction(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public int multiplication(int firstNumber, int secondNumber)
        { 
            return firstNumber * secondNumber;
            }

        public int division(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }
        public string GetMessage()
        {
            return "IT Rockstar";
        }

    }
}
