using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ADOPrac.PresentationLayer.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            //Db Log
            Console.WriteLine($"Exception: {context.Exception.Message} occured at controller " +
                $"{context.RouteData.Values["controller"]} and action {context.RouteData.Values["action"]}");

            context.Result = new RedirectToActionResult("Index", "Error" , null);

            context.ExceptionHandled = true;
        }
    }
}
