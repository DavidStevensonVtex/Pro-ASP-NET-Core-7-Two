﻿// Listing 14.1 The contents of the IResponseFormatter.cs file in the Services folder

namespace Platform.Services
{
	public interface IResponseFormatter
	{
		Task Format(HttpContext context, string content);
	}
}
