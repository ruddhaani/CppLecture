using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inp = Convert.ToInt16(Console.ReadLine());
            switch (inp)
            {
                case 1:
                    Console.WriteLine("Red");
                    break;

                case 2:
                    Console.WriteLine("Yellow");
                    break;

                case 3:
                    Console.WriteLine("Yellow");
                    break;
            }
        }
    }
}
