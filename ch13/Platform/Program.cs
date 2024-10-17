// Listing 13.15 Matching part of a segment in the Program.cs file in the Platform folder

using Platform;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("files/{filename}.{ext}", async context =>
{
	await context.Response.WriteAsync("Request Was Routed\n");
	foreach (var kvp in context.Request.RouteValues)
	{
		await context.Response.WriteAsync($"{kvp.Key} : {kvp.Value}\n");
	}
});

app.MapGet("capital/{country}", Capital.Endpoint);
app.MapGet("size/{city}", Population.Endpoint)
	.WithMetadata(new RouteNameMetadata("population"));

app.Run();
