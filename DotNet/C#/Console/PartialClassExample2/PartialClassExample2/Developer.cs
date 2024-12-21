using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExample2
{
    public class Developer
    {
    }

    public partial class Employee
    {
        public void ProjectName()
        {
            Console.WriteLine("XYZ");
        }
    }
}
