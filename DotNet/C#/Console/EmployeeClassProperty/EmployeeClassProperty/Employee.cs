using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassProperty
{
    internal class Employee : Audit
    {


        public string EmployeeName { get; set; }
        public int EmployeeID { get; set; }
        public float EmployeeSalary {  get; set; }

    }
}
