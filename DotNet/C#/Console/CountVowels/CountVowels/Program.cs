using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountVowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string str=Console.ReadLine();
            int count=str.Count(c => "aeiouAEIOU".Contains(c));
            Console.WriteLine("vowels count is "+count);
        }
    }
}
