using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructorExample1
{
    internal class Employee
    {
        private int age;

        public Employee(int age)
        {
            this.age = age;
        }

        public Employee(Employee employee)
        {
            this.age = employee.age;
        }

        public void displayAge()
        {
            Console.WriteLine(age);
        }
    }
}
