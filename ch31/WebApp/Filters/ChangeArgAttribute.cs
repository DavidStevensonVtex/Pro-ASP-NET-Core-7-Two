// Listing 30.23 Using a filter base class the ChangeArgAttribute.cs to the Filter folder

using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApp.Filters
{
    public class ChangeArgAttribute : ActionFilterAttribute
    {
        public override async Task OnActionExecutionAsync(
            ActionExecutingContext context, 
            ActionExecutionDelegate next)
        {
            if (context.ActionArguments.ContainsKey("message1"))
            {
                context.ActionArguments["message1"] = "New message";
            }
            await next();
        }
    }
}
