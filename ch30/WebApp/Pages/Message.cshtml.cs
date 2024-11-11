// Listing 30.26 Using a page filter in the Message.cshtml.cs file in the Pages folder

namespace WebApp.Pages
{
    [RequireHttps]
    //[SimpleCache]
    [ChangePageArgs]
    public class MessageModel : PageModel
    {
        public object Message { get; set; }

        public void OnGet(string message1, string message2)
        {
            Message = $"{message1}, {message2}";
        }
    }
}
