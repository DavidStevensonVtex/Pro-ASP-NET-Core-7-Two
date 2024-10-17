// Listing 13.6 Using components as endings in the Program.cs file in the Platform folder

using Platform;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.UseMiddleware<Population>();
//app.UseMiddleware<Capital>();

app.UseRouting();

#pragma warning disable ASP0014

app.UseEndpoints(endpoints =>
{
	endpoints.MapGet("routing", async context =>
	{
		await context.Response.WriteAsync("Request was routed");
	});

	endpoints.MapGet("capital/uk", new Capital().Invoke);
	endpoints.MapGet("population/paris", new Population().Invoke);
});

app.Run(async (context) =>
{
	await context.Response.WriteAsync("Terminal Middleware Reached");
});

app.Run();
