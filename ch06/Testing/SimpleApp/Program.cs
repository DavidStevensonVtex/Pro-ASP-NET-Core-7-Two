// Listing 6.3 Enabling the MVC Framework in the Program.cs file inthe SimpleApp folder

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!")
app.MapDefaultControllerRoute();

app.Run();
