// Listing 4.4 Adding a statement in the Program.cs file in the MyProject folder

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.UseStaticFiles();

app.Run();