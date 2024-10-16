// Listing 12.11 Creating a pipeline branch in the Program.cs file in the Platform folder

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Map("/branch", branch =>
{
	branch.UseMiddleware<Platform.QueryStringMiddleWare>();

	branch.Use(async (HttpContext context, Func<Task> next) =>
	{
		await context.Response.WriteAsync($"Branch Middleware");
	});
});

app.UseMiddleware<Platform.QueryStringMiddleWare>();

app.MapGet("/", () => "Hello World!");

app.Run();
