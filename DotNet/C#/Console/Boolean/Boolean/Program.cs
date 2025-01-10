using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isHappy = true;
            bool isSad = false;
            Console.WriteLine(isHappy);
            Console.WriteLine(isSad);


            int x = 45;
            int y = 89;
            Console.WriteLine(x > y);

            Console.WriteLine(56 < 87);

            double pi = 3.14;
            Console.WriteLine( pi==3.14);

            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age>=18)
            {
                Console.WriteLine("old enough to vote");
            }
            else
            {
                Console.WriteLine("Not old enough to old");
            }
        }
    }
}
