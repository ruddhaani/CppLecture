using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructorExample3
{
    public static class Employee
    {   
        //static class cant have parameterized constructor  
        static Employee(string name)
        {

        }
    }
}
