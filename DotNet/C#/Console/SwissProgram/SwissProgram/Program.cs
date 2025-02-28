using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char nor = ' ';
            bool isRepeated = false;
            for(int i=0;i<str.Length-1;i++)
                {
                for(int j=i+1;j<str.Length-1;j++)
                {
                    if (str[i] == str[j])
                    {
                        isRepeated = true;
                        break;
                    }
                }
                
                if(isRepeated == false)
                {
                    Console.Write(str[i]);
                    return;
                }

                isRepeated = false;
            }
            
        }
    }
}
