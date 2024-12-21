using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inp = Convert.ToInt16(Console.ReadLine());
            switch (inp)
            {
                case 1:
                    Console.WriteLine("Dog");
                    break;

                case 2:
                    Console.WriteLine("Cat");
                    break;

                case 3:
                    Console.WriteLine("Cow");
                    break;
            }
        }
    }
}
