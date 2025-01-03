// Listing 15.30 Configuring the static files middleware in the Program.cs file in the Platform folder

using Platform;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpLogging(opts => {
	opts.LoggingFields = HttpLoggingFields.RequestMethod
		| HttpLoggingFields.RequestPath
		| HttpLoggingFields.ResponseStatusCode;
});

var app = builder.Build();

app.UseHttpLogging();

var env = app.Environment;
app.UseStaticFiles();

//app.UseStaticFiles(new StaticFileOptions
//{
//	FileProvider = new PhysicalFileProvider($"{env.ContentRootPath}/staticfiles"),
//	RequestPath = "/files"
//});

app.MapGet("population/{city?}", Population.Endpoint);

app.Run();
