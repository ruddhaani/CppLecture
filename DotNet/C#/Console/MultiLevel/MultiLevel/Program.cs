using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer();

            developer.Name = "prajakta";
            developer.Id= 1;
            developer.salary = 50000;
            developer.ProjectName = "POS";

            Console.WriteLine("Name is "+developer.Name);
            Console.WriteLine("Id is " + developer.Id);
            Console.WriteLine("salary is "+developer.salary);
            Console.WriteLine("Project Name is "+ developer.ProjectName);

            Console.ReadLine();

        }
    }
}
