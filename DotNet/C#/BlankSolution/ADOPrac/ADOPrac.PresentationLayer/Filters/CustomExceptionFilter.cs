using Custom_Logger;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ADOPrac.PresentationLayer.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        private readonly IConfiguration _configuration;

        public CustomExceptionFilter(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnException(ExceptionContext context)
        {
            //Db Log
            string errorMessage = $"Exception: {context.Exception.Message}. This error occured at controller " +
                $"{context.RouteData.Values["controller"]} and action {context.RouteData.Values["action"]}";

            Logger.LogToFile("Error", errorMessage, _configuration["Logger:FolderPath"]);

            context.Result = new RedirectToActionResult("Index", "Error" , null);

            context.ExceptionHandled = true;
        }
    }
}
