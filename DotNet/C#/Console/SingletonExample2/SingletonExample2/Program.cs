using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton.CreateSingletonObj();
            Singleton.CreateSingletonObj();
            Singleton.CreateSingletonObj();
            Singleton.CreateSingletonObj();
        }
    }
}
