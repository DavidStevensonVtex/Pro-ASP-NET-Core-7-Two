﻿// Listing 14.2 The contents of the TextResponseFormatter.cs file in the Services folder

namespace Platform.Services
{
	public class TextResponseFormatter
	{
		private int responseCounter = 0;

		public async Task Format(HttpContext context, string content)
		{
			await context.Response.WriteAsync($"Response: {++responseCounter}:\n{content}");
		}
	}
}
