﻿// Listing 3.15 Adding a ListResponses action in the HomeController.cs file in the Controllers folder

using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public ViewResult RsvpForm()
		{
			return View();
		}

		[HttpPost]
		public ViewResult RsvpForm(GuestResponse guestResponse)
		{
			Repository.AddResponse(guestResponse);
			return View("Thanks", guestResponse);
		}

		public ViewResult ListResponses()
		{
			return View(Repository.Responses.Where(r => r.WillAttend == true));
		}
	}
}
