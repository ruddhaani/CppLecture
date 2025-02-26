using System.Diagnostics;
using ADOPrac.BusinessLogicLayer.Models;
using ADOPrac.PresentationLayer.Filters;
using ADOPrac.PresentationLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace ADOPrac.PresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [ServiceFilter(typeof(CustomResultFilter))]
        public IActionResult Test()
        {
            var company = new List<Company>();

            company.Add(new Company()
            {
                CompanyName = "CORECO",
                CompanyAddress = "Pune"
            });

            company.Add(new Company()
            {
                CompanyName = "BitWise",
                CompanyAddress = "Pune"
            });

            return Json(company);
        }

        //[ServiceFilter(typeof(CustomAuthorizationFilter))]
        //[ServiceFilter(typeof(CustomActionFilter))]
        //[ServiceFilter(typeof(CustomExceptionFilter))]
        //[ServiceFilter(typeof(CustomResultFilter))]

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Unauthorized()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
