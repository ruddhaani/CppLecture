using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryProgram2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> studentObj = new Dictionary<int, string>();
            studentObj.Add(1,"Prajakta");
            studentObj.Add(5, "Dipika");
            studentObj.Add(12, "Pornima");
            studentObj.Add(34, "Deep");
            studentObj.Add(23, "Sarvadnya");

            Console.WriteLine("Student dictionary");
            foreach(var student in studentObj)
            {
                //Console.WriteLine(student);
                Console.WriteLine(student.Key)
            }
        }
    }
}
