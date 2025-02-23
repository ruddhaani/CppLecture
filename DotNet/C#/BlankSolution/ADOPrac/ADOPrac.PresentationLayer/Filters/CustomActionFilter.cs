using Microsoft.AspNetCore.Mvc.Filters;

namespace ADOPrac.PresentationLayer.Filters
{
    public class CustomActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            //Logic here
            Console.WriteLine("OnActionExecuted called.");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //Logic here
            Console.WriteLine("OnActionExecuting called.");
        }
    }
}
