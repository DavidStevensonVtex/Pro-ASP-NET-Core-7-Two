// Listing 12.12 Using the run method in the Program.cs file in the Platform folder

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Map("/branch", branch =>
{
	branch.UseMiddleware<Platform.QueryStringMiddleWare>();

	branch.Run(async (HttpContext context) =>
	{
		await context.Response.WriteAsync($"Branch Middleware");
	});
});

app.UseMiddleware<Platform.QueryStringMiddleWare>();

app.MapGet("/", () => "Hello World!");

app.Run();
