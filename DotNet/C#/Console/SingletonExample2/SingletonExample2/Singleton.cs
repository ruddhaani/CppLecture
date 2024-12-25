using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample2
{
    internal class Singleton
    {
        public static Singleton singletonObj;
        private Singleton()
        {

        }

        public static Singleton CreateSingletonObj()
        {
            if(singletonObj == null)
            {
                singletonObj = new Singleton();
                Console.WriteLine("New created");
                return singletonObj;
            }
            else
            {
                Console.WriteLine("Old Object");
                return singletonObj;
            }
        }
    }
}
