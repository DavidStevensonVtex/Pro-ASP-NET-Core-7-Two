// Listing 39.9 Applying an authorization attribute in the AdminPageModel.cs file in the Pages folder in the Advanced project

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Advanced.Pages
{
    [Authorize(Roles="Admins")]
    public class AdminPageModel : PageModel
    {
    }
}
