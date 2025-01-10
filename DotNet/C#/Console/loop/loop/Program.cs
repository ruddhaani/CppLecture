using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i >=-0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Enter name ");
            string name=Console.ReadLine();
            int n =Convert.ToInt32(Length(name));
            for(int i = 0;i<n/2;i++)
            {

            }
        }

       
    }
}
