// Listing 31.4 Disabling filters in the Program.cs file in the WebApp folder

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext> (opts =>
{
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:ProductConnection"]);
    opts.EnableSensitiveDataLogging(true);
});

 builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddScoped<GuidResponseAttribute>();
//builder.Services.Configure<MvcOptions>(opts =>
//{
//    opts.Filters.Add<HttpsOnlyAttribute>();
//    opts.Filters.Add(new MessageAttribute("This is the globally-scoped filter"));
//});

var app = builder.Build();

app.UseStaticFiles();
app.MapControllerRoute("forms", "controllers/{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

var context = app.Services.CreateScope().ServiceProvider.GetRequiredService<DataContext>();
SeedData.SeedDatabase(context);

app.Run();