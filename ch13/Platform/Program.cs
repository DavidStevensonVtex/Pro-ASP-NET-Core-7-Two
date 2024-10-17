// Listing 13.5 Using the routing middleware of the Program.cs file in the Platform folder

using Platform;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseMiddleware<Population>();
app.UseMiddleware<Capital>();

app.UseRouting();

#pragma warning disable ASP0014

app.UseEndpoints(endpoints =>
{
	endpoints.MapGet("routing", async context =>
	{
		await context.Response.WriteAsync("Request was routed");
	});
});

app.Run(async (context) =>
{
	await context.Response.WriteAsync("Terminal Middleware Reached");
});

app.Run();
