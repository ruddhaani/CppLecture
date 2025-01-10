using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee obj=new Employee();

            

            obj.message1("Prajakta",12,"P");
            Console.WriteLine(obj.message1("Prajakta ", 12, " P "));
            obj.message1("Prajakta",".Net");
            Console.WriteLine(obj.message1("Prajakta", ".Net"));


            Console.ReadLine();
        }
    }
}
