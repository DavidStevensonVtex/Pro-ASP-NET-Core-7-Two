﻿// Listing 3.3 The contents of the HomeController.cs file in the Controllers folder

using Microsoft.AspNetCore.Mvc;

namespace PartyInvites.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
