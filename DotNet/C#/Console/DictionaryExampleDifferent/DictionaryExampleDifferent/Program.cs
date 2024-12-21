using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExampleDifferent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Employee, Manager> dictionaryObj = new Dictionary<Employee, Manager>();
            Employee obj = new Employee();
            obj.department = "HR";
            obj.eid = 1;
            obj.name = "Ani";

            Manager mObj = new Manager();
            mObj.NumberOfProjects = 1;
            mObj.ProjectName = "xyz";

            dictionaryObj.Add(obj, mObj);

            foreach (var item in dictionaryObj)
            {
                Console.WriteLine(item.Key.department + " " + item.Value.ProjectName);
            }
        }
    }
}
