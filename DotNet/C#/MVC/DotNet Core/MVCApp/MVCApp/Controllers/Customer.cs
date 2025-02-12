using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Controllers
{
    public class Customer : Controller
    {
        public IActionResult User()
        {
            ViewBag.Data = "Hello world from ViewBag";
            return View();
        }

        public IActionResult SecondUser()
        {
            return View();
        }
    }
}
