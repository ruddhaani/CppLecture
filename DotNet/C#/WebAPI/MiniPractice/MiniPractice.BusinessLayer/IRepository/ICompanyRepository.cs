using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MiniPractice.BusinessLayer.Models;

namespace MiniPractice.BusinessLayer.IRepository
{
    public interface ICompanyRepository
    {
        public void Update(Company company);

        public void Delete(Company company);

        public int Create(Company company);

        public List<Company> List();

        public Company GetById();
    }
}
