﻿// Listing 3.17 Applying validation in the GuestResponse.cs file in the Models folder

using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
	public class GuestResponse
	{
		[Required(ErrorMessage = "Please enter your name")]
		public string? Name { get; set; }

		[Required(ErrorMessage = "Please enter your email address")]
		public string? Email { get; set; }

		[Required(ErrorMessage = "Please enter your phone number")]
		public string? Phone { get; set; }

		[Required(ErrorMessage = "Please specify whether you're attend")]
		public bool? WillAttend { get; set; }
	}
}
