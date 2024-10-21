// Listing 15.27 HTTP Logging message options in the Program.cs file in the Platform folder

using Platform;
using Microsoft.AspNetCore.HttpLogging;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpLogging(opts => {
	opts.LoggingFields = HttpLoggingFields.RequestMethod
		| HttpLoggingFields.RequestPath
		| HttpLoggingFields.ResponseStatusCode;
});

var app = builder.Build();

app.UseHttpLogging();

app.MapGet("population/{city?}", Population.Endpoint);

app.Run();
