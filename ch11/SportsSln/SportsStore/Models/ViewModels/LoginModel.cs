// Listing 11.12 The LoginModel.cs file in the SportsStore/Models/ViewModels folder

namespace SportsStore.Models.ViewModels
{
    public class LoginModel
    {
        public required string Name { get; set; }
        public required string Password { get; set; }
        public string ReturnUrl { get; set; } = "/";
    }
}
