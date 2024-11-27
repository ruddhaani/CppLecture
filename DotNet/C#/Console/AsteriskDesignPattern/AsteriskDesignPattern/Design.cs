using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteriskDesignPattern
{
    public class Design
    {
        public void DesignPattern(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
