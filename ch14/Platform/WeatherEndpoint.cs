﻿// Listing 14.8 Using a singleton in the WeatherEndpoint.cs file in the Platform folder

using Platform.Services;

namespace Platform
{
	public class WeatherEndpoint
	{
		public static async Task Endpoint (HttpContext context)
		{
			await TextResponseFormatter.Singleton.Format(context,
				"Endpoint Class: It is cloudy in Milan");
		}
	}
}
