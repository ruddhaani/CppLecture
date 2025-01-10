using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heightOfPersonIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  height;
            Console.WriteLine("Enter height in cm");
            height = Convert.ToInt32(Console.ReadLine());
            if(height<0)
            {
                Console.WriteLine("invalid");
                return;
            }
            {
                if (height>=0 && height < 150)
                {
                    Console.WriteLine("Dwarf");
                }
                else if ((height >= 150) && (height <= 165))
                {
                    Console.WriteLine("Average Height");
                }
                else
                {
                    Console.WriteLine("taller");
                }
            }
           


        }
    }
}
