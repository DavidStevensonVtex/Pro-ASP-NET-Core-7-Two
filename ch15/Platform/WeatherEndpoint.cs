﻿// Listing 14.25 Moving the dependency in the WeatherEndpoint.cs file in the Platform folder

using Platform.Services;

namespace Platform
{
	public class WeatherEndpoint
	{
		//private IResponseFormatter formatter;

		//public WeatherEndpoint(IResponseFormatter responseFormatter)
		//{
		//	formatter = responseFormatter;
		//}

		public async Task Endpoint (HttpContext context, IResponseFormatter formatter)
		{
			await formatter.Format(context,
				"Endpoint Class: It is cloudy in Milan");
		}
	}
}
