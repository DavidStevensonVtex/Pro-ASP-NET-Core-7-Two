﻿// Listing 14.19 The contents of the EndpointExtensions.cs file in the Services folder

using System.Reflection;

namespace Microsoft.AspNetCore.Builder
{
	public static class EndpointExtensions
	{
		public static void MapEndpoint<T>(this IEndpointRouteBuilder app,
			string path, string methodName = "Endpint")
		{
			MethodInfo? methodInfo = typeof(T).GetMethod(methodName);
			if (methodInfo?.ReturnType != typeof(Task))
			{
				throw new Exception("Method cannot be used");
			}
			T endpointInstance = ActivatorUtilities.CreateInstance<T>(app.ServiceProvider);
			app.MapGet(path, (RequestDelegate)methodInfo
				.CreateDelegate(typeof(RequestDelegate), endpointInstance));
		}
	}
}
