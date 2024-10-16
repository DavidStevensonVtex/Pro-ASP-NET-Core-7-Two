﻿// Listing 12.7 The contents of the Middleware.cs file in the Platform folder

namespace Platform
{
	public class QueryStringMiddleWare
	{
		private RequestDelegate next;

		public QueryStringMiddleWare(RequestDelegate nextDelegate)
		{
			next = nextDelegate;
		}

		public async Task Invoke(HttpContext context)
		{
			if (context.Request.Method == HttpMethods.Get &&
				context.Request.Query["custom"] == "true")
			{
				context.Response.ContentType = "text/plain";
				await context.Response.WriteAsync("Custom Middleware \n");
			}
			await next(context);
		}
	}
}
