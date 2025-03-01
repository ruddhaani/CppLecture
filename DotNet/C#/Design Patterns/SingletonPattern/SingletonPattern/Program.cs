using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerSingleton _instance1 = LoggerSingleton.GetLogger();
            LoggerSingleton _instance2 = LoggerSingleton.GetLogger();

            LoggerNotSingleton _instance3 = new LoggerNotSingleton();
            LoggerNotSingleton _instance4 = new LoggerNotSingleton();


            //comparing singleton gives similar object (false)
            Console.WriteLine(_instance1.Equals(_instance2));

            //comparing non singleton gives two different object (false)
            Console.WriteLine(_instance3.Equals(_instance4));


            _instance1.GetLogMessage("aaizavli");
            _instance2.GetLogMessage("nahi zavli");
        }
    }
}
