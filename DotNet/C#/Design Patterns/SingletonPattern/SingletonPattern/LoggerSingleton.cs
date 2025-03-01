using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class LoggerSingleton
    {
        private static LoggerSingleton _instance;

        private LoggerSingleton()
        {
            Console.WriteLine("Object created.");
        }

        public static LoggerSingleton GetLogger()
        {
            if(_instance == null)
            {
                _instance = new LoggerSingleton();
            }

            return _instance;
        }

        public void GetLogMessage(string message)
        {
            Console.WriteLine($"Message: {message}");
        }
    }
}
