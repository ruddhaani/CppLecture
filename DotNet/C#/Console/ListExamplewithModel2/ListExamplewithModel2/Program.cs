using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ListExamplewithModel2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>()
            {
                new Student { StudentId = 1 , Name = "Aniruddha" , Standard = 14},
                new Student {StudentId = 2 , Name = "Snehal" , Standard = 1}
            };

            if(studentList.Count > 0)
            {
                foreach(var item in studentList)
                {
                    Console.WriteLine(item.StudentId);
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.Standard);
                }
            }
        }
    }
}
