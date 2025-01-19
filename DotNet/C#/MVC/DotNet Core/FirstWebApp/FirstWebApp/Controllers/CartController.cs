using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Cart()
        {
            return View();
        }
    }
}
