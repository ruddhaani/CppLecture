using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassExample
{
    internal static class Logs
    {
        public static void Debug(string message)
        {
            Console.WriteLine(message);
        }

        public static void Error(string message)
        {
            Console.WriteLine(message);
        }

        public static void Info(string message)
        {
            Console.WriteLine(message);
        }
    }
}
