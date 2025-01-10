using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExample
{
    internal class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {

            this.name = name;
            this.age = age;
        }
        public void display()
        {
            Console.WriteLine("name is " + name + " age is " + age);
        }
    }
}
