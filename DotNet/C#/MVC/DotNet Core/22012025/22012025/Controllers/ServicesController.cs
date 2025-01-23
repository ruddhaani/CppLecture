using _22012025.Models;
using Microsoft.AspNetCore.Mvc;

namespace _22012025.Controllers
{
    public class ServicesController : Controller
    {

        [HttpGet]
        public IActionResult MyServices()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MyServices(MyServicesModel myServicesModel)
        {
            return View();
        }
    }
}
