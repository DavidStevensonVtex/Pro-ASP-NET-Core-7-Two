// Listing 21.6 The default routing convention in the Program.cs file in the WebApp folder

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext> (opts =>
{
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:ProductConnection"]);
    opts.EnableSensitiveDataLogging(true);
});

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllers();
app.MapDefaultControllerRoute();

app.UseStaticFiles();
app.MapGet("/", () => "Hello World!");

var context = app.Services.CreateScope().ServiceProvider.GetRequiredService<DataContext>();
SeedData.SeedDatabase(context);

app.Run();