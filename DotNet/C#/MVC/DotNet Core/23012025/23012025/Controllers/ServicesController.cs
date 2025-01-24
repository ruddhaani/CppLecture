using _23012025.Models;
using Microsoft.AspNetCore.Mvc;

namespace _23012025.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult MyServices()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MyServices(MyServicesModel myServicesModel)
        {
            return View(myServicesModel);
        }

        [HttpGet]
        public IActionResult Company()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Company(CompanyModel companyModel)
        {
            if (ModelState.IsValid) {
                return View(companyModel);
            }

            throw new Exception("Error in validation");
        }
    }
}
