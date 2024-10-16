// Listing 12.18 Using class-based middleware in the Program.cs file in the Platform folder

using Platform;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<MessageOptions>(options =>
{
	options.CityName = "Albany";
});

var app = builder.Build();

app.UseMiddleware<LocationMiddleware>();

app.UseMiddleware<Platform.QueryStringMiddleWare>();

app.MapGet("/", () => "Hello World!");

app.Run();
