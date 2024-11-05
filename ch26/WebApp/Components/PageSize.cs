﻿// Listing 24.26 The contents of the PageSize.cs file in the Components folder

using Microsoft.AspNetCore.Mvc;

namespace WebApp.Components
{
    public class PageSize : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://microsoft.com");
            return View(response.Content.Headers.ContentLength);
        }
    }
}
