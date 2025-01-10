using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate void contentDisplay();
    delegate int calculatorDisplay(int firstNumber, int secondNumber);
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //this is multicast delegate because we create only one object of delegate and call method by it
            Content objContent = new Content();
            contentDisplay delObj = new contentDisplay(objContent.Display);
            delObj += objContent.Show;
            delObj += objContent.Print;
            delObj();


            //this is not multicast delegate this is single cast delegate 
            MultiCastDelegate arithmeticObj = new MultiCastDelegate(); //class object

            calculatorDisplay AddObj = new calculatorDisplay(arithmeticObj.Add);
            Console.WriteLine("addition is "+AddObj(10, 20));

            calculatorDisplay SubObj = new calculatorDisplay(arithmeticObj.Sub);
            Console.WriteLine("Subtraction is "+SubObj(50, 30));

            calculatorDisplay MulObj = new calculatorDisplay(arithmeticObj.Mul);
            Console.WriteLine("Multiplication is "+MulObj(3, 10));

            calculatorDisplay DivObj = new calculatorDisplay(arithmeticObj.Div);
            Console.WriteLine("Division is "+DivObj(24, 2));

           



            //here we used class object for call function
            //but we used here delegates not call using objects

            //Content obj = new Content();
            // contentDisplay delObj = obj.Show;
            // //delObj();

            // //contentDisplay delObj1 = obj.Display;
            // //delObj1();

            // delObj += obj.Display;
            // delObj += obj.Print;
            // delObj();

            //// contentDisplay delObj2 = obj.Print;
            //// delObj2();

            //contentDisplay obj3 = new contentDisplay(obj.Display);
            //obj3 += obj.Show;
            //obj3 += obj.Print;
            ////obj3 += obj.Content1;
            //obj3();


            // MultiCastDelegate cal = new MultiCastDelegate();

            //       calculatorDisplay AddObj = cal.Add;
            //        Console.WriteLine("Addition is " + AddObj(20, 30));

            //        calculatorDisplay SubObj = cal.Sub;
            //        Console.WriteLine("Subtraction is " + SubObj(80, 30));

            //        calculatorDisplay MulObj = cal.Mul;
            //        Console.WriteLine("Multiplication is " + MulObj(20, 6));

            //calculatorDisplay DivObj = cal.Div;
            //Console.WriteLine("Division is " + DivObj(90, 30));



        }
    }
}
