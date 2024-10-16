// Listing 12.14 Applying middleware the Program.cs file in the Platform folder

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

((IApplicationBuilder)app).Map("/branch", branch =>
{
	branch.Run(new Platform.QueryStringMiddleWare().Invoke);
});

app.UseMiddleware<Platform.QueryStringMiddleWare>();

app.MapGet("/", () => "Hello World!");

app.Run();
