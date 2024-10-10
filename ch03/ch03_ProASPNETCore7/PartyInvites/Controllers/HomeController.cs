﻿// Listing 3.7 Adding an action in the HomeController.cs file in the Controllers folder

using Microsoft.AspNetCore.Mvc;

namespace PartyInvites.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public ViewResult RsvpForm()
		{
			return View();
		}
	}
}
