﻿// Listing 14.31 The contents of the TimeResponseFormatter.cs fiel in the Services folder


namespace Platform.Services
{
	public class TimeResponseFormatter : IResponseFormatter
	{
		private ITimeStamper stamper;

		public TimeResponseFormatter(ITimeStamper timeStamper)
		{
			stamper = timeStamper;
		}

		public async Task Format(HttpContext context, string content)
		{
			await context.Response.WriteAsync($"{stamper.TimeStamp}");
		}
	}
}
