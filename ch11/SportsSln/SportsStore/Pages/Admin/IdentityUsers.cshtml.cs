// Listing 11.10 Restricting access in the IdentityUsers.cshtml.cs file in the SportsStore/Pages/Admin folder 

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SportsStore.Pages.Admin
{
    [Authorize]
    public class IdentityUsersModel : PageModel
    {
        private UserManager<IdentityUser> userManager;

        public IdentityUsersModel(UserManager<IdentityUser> mgr)
        {
            userManager = mgr;
        }

        public IdentityUser? AdminUser { get; set; } = new();

        public async Task OnGetAsync()
        {
            AdminUser = await userManager.FindByNameAsync("Admin");
        }
    }
}
