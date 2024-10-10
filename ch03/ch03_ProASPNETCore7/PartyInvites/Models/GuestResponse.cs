// Listing 3.6 The contents of the GuestResponse.cs file in the Models folder

namespace PartyInvites.Models
{
	public class GuestResponse
	{
		public string? Name { get; set; }
		public string? Email { get; set; }
		public string? Phone { get; set; }
		public bool? WillAttend { get; set; }
	}
}
