// Listing 30.4b The contents of the Message.cshtml file in the Pages folder

namespace WebApp.Pages
{
    public class MessageModel : PageModel
    {
        public object Message { get; set; } = "This is the Message Razor Page";
        public void OnGet()
        {
        }
    }
}
