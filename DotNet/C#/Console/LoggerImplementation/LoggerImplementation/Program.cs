using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace LoggerImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string baseDir = "D:\\LogFiles\\";
            try
            {
                int num1 = 10;
                int num2 = 0;

                Console.WriteLine(num1 / num2);
            }
            catch(Exception e)
            {
                Logs.Error(e.Message, baseDir);
            }
            
        }
    }
}
