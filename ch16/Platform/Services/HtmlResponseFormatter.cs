﻿// Listing 14.37 Overriding the RichOutput property in the HtmlResponseFormatter.cs file in the Services folder

namespace Platform.Services
{
	public class HtmlResponseFormatter : IResponseFormatter
	{
		public async Task Format(HttpContext context, string content)
		{
			context.Response.ContentType = "text/html";
			await context.Response.WriteAsync($@"
				<!DOCTYPE html>
				<html lang=""en"">
					<head><title>Response</title></head>
					<body>
						<h2>Formatted Response</h2>
						<span>{content}</span>
					</body>
				</html>");
		}

		public bool RichOutput => true;
	}
}
