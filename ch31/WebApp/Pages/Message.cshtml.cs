// Listing 30.27 Using the filter methods in the Message.cshtml.cs file in the Pages folder

using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApp.Pages
{
    [RequireHttps]
    //[SimpleCache]
    //[ChangePageArgs]
    public class MessageModel : PageModel
    {
        public object Message { get; set; } = string.Empty;

        public void OnGet(string message1, string message2)
        {
            Message = $"{message1}, {message2}";
        }

        public override void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            if (context.HandlerArguments.ContainsKey("message1"))
            {
                context.HandlerArguments["message1"] = "New message";
            }
        }
    }
}
