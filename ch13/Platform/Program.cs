// Listing 13.3 Replacing the contents of the Program.cs file in the Platform folder

using Platform;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseMiddleware<Population>();
app.UseMiddleware<Capital>();
app.Run(async (context) =>
{
	await context.Response.WriteAsync("Terminal Middleware Reached");
});

app.Run();
