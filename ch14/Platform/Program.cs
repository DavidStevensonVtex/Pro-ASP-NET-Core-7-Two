// Listing 14.20 Creating a route in the Program.cs file in the Platform folder

using Platform;
using Platform.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IResponseFormatter, HtmlResponseFormatter>();

var app = builder.Build();

app.UseMiddleware<WeatherMiddleware>();

//app.MapGet("endpoint/class", WeatherEndpoint.Endpoint);
app.MapEndpoint<WeatherEndpoint>("endpoint/class");

//IResponseFormatter formatter = TypeBroker.Formatter;
app.MapGet("endpoint/function", async (HttpContext context, IResponseFormatter formatter) =>
{
	await formatter.Format(context, "It is sunny in LA");
});

app.Run();
