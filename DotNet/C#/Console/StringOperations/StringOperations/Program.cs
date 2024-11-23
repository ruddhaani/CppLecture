using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Status statusObj = new Status();
            string name = "approved";
            string reqtype = "Web Developer";
            string nameofDev= "Aniruddha";
            //Console.WriteLine(name.Length);
            //Console.WriteLine(name.ToUpper());
            //Console.WriteLine(name.ToLower());

            if ((statusObj.StatusValue().Trim().ToUpper() == name.Trim().ToUpper() && statusObj.RequestType().Trim().ToUpper() == reqtype.Trim().ToUpper()) || (statusObj.DevName().Trim().ToUpper() == nameofDev.Trim().ToUpper()))
            {
                Console.WriteLine("you have been approved & request type is web");
            }
            else
            {
                Console.WriteLine("you are still in progress");
            }



            //string name1 = "Shreyas";

            //Console.WriteLine(name1);

            //name1 = "Aniruddha";

            //Console.WriteLine(name1);

            //int number = 5;

            //number += 6;
            
            //Console.WriteLine(number);

            //number -= 4;

            //Console.WriteLine(number);

            //number++;

            //Console.WriteLine(number);

            //number--;

            //Console.WriteLine(number);

        }
    }
}

