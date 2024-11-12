// Listing 30.25 The contents of the ChangePageArgs.cs file in the Filters folder

using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApp.Filters
{
    public class ChangePageArgs : Attribute, IPageFilter
    {
        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
            // do nothing
        }
        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            if (context.HandlerArguments.ContainsKey("message1"))
            {
                context.HandlerArguments["message1"] = "New message";
            }
        }

        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
            // do nothing
        }
    }
}
