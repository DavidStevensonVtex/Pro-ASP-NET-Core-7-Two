﻿// Listing 12.13 Adding terminal support the Middleware.cs file in the Platform folder

namespace Platform
{
	public class QueryStringMiddleWare
	{
		private RequestDelegate? next;

		public QueryStringMiddleWare()
		{
			// do nothing
		}

		public QueryStringMiddleWare(RequestDelegate nextDelegate)
		{
			next = nextDelegate;
		}

		public async Task Invoke(HttpContext context)
		{
			if (context.Request.Method == HttpMethods.Get &&
				context.Request.Query["custom"] == "true")
			{
				if (! context.Response.HasStarted)
				{
					context.Response.ContentType = "text/plain";
				}
				
				await context.Response.WriteAsync("Class Middleware \n");
			}
			if (next != null)
			{
				await next(context);
			}
		}
	}
}
