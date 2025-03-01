using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class LoggerNotSingleton
    {
        public LoggerNotSingleton()
        {
            Console.WriteLine("Created");
        }
    }
}
