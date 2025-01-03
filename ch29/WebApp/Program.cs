// Listing 29.10 Changing a validation message in the Program.cs file in the WebApp folder

using Microsoft.AspNetCore.Antiforgery;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext> (opts =>
{
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:ProductConnection"]);
    opts.EnableSensitiveDataLogging(true);
});

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddSingleton<CitiesData>();

builder.Services.Configure<AntiforgeryOptions>(opts =>
{
    opts.HeaderName = "X-XSRF-TOKEN";
});

builder.Services.Configure<MvcOptions>(opts =>
    opts.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(value => "Please enter a value"));

var app = builder.Build();

app.UseStaticFiles();

IAntiforgery antiForgery = app.Services.GetRequiredService<IAntiforgery>();
app.Use(async (context, next) =>
{
    if (!context.Request.Path.StartsWithSegments("/api"))
    {
        string? token = antiForgery.GetAndStoreTokens(context).RequestToken;
        if (token != null)
        {
            context.Response.Cookies.Append("XSRF-TOKEN", token, new CookieOptions { HttpOnly = false });
        }
    }
    await next();
});

app.MapControllerRoute("forms", 
    "controllers/{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

var context = app.Services.CreateScope().ServiceProvider.GetRequiredService<DataContext>();
SeedData.SeedDatabase(context);

app.Run();