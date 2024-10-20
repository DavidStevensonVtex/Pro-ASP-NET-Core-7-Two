﻿// Listing 14.21 The contents of the GuidService.cs file in the Services folder

namespace Platform.Services
{
	public class GuidService : IResponseFormatter
	{
		private Guid guid = Guid.NewGuid();

		public async Task Format(HttpContext context, string content)
		{
			await context.Response.WriteAsync($"Guid: {guid}\n{content}");
		}
	}
}
