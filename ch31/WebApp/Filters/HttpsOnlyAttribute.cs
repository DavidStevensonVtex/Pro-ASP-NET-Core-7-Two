// Listing 30.16 The contents of the HttpsOnlyAttribute.cs file int he Filters folder

using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApp.Filters
{
    public class HttpsOnlyAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!context.HttpContext.Request.IsHttps)
            {
                context.Result = new StatusCodeResult(StatusCodes.Status403Forbidden);
            }
        }
    }
}
