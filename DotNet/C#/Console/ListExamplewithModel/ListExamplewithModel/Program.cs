using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExamplewithModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeesObj = new List<Employee>(
                new Employee { Name="Rohit" , Salary = 1234 , Email = "abc.xyz.com"}
                
                );

            //traditional approach
            //Employee obj1 = new Employee();
            //obj1.Name = "Aniruddha";
            //obj1.Salary = 12345;
            //obj1.Email = "abc@gmail.com";

            //Employee obj2 = new Employee();
            //obj2.Name = "Snehal";
            //obj2.Salary = 999999;
            //obj2.Email = "xyz@gmail.com";

            //employeesObj.Add(obj1);
            //employeesObj.Add(obj2);

            //to check if it is not empty.
            if (employeesObj.Count > 0) {
                foreach (var i in employeesObj)
                {
                    Console.WriteLine(i.Name);
                    Console.WriteLine(i.Salary);
                    Console.WriteLine(i.Email);
                }
            }

            Console.WriteLine(employeesObj.Count);
        }
    }
}
