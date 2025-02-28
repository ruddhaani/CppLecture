using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWordsinAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            int start = 0;
            int stop = 0;
            int i = 0;
            bool flag = false;

            while(i <= inp.Length -1)
            {
                if (inp[i] == ' ' || i == inp.Length - 1)
                {
                    flag = true;
                    stop = i - 1;
                }

                if (flag)
                {
                    for(int j = stop; j>= start; j--)
                    {
                        Console.Write(inp[j]);
                    }

                    Console.Write(" ");
                    flag = false;
                    start = i + 1;
                }
                i++;
            }
        }
    }
}
