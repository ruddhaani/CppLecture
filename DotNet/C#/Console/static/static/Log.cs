using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
     public static class Log
{
        public static void Info(string message)
        {
            Console.WriteLine(message);
        }

        public static void Debug(string message)
        {
            Console.WriteLine(message);
        }  
        public static void Error(string message)
        {
            Console.WriteLine(message);
        }
    }
}
