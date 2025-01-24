using _22012025.Models;
using Microsoft.AspNetCore.Mvc;

namespace _22012025.Controllers
{
    public class ServicesController : Controller
    {

        public IActionResult MyServices()
        {
            return View();
        }

        public IActionResult Company()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CompanyData(CompanyModel companyModel)
        {
            return View(companyModel);
        }


    }
}
