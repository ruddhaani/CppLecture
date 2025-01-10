using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProject
{
    public class Manager: IEmployee, ICompany
    {
        public string message()
        {
            return "message";
        }

        public string CompanyDetails()
        {
            return "Company";
        }
        

    }
}
