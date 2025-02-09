using Microsoft.AspNetCore.Mvc;
using MiniPractice.BusinessLayer.IRepository;
using MiniPractice.BusinessLayer.Models;

namespace MiniPractice.Presentation.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        public IActionResult Company()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Company company)
        {
            _companyRepository.Create(company);
            return Ok();
        }
    }
}
