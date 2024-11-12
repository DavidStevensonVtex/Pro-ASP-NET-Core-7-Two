// Listing 30.37 Creating a global filter in the Program.cs file in the WebApp folder

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext> (opts =>
{
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:ProductConnection"]);
    opts.EnableSensitiveDataLogging(true);
});

// builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add<HttpsOnlyAttribute>();
});
builder.Services.AddRazorPages();

builder.Services.AddScoped<GuidResponseAttribute>();
//builder.Services.Configure<MvcOptions>(opts =>
//    opts.Filters.Add<HttpsOnlyAttribute>());

var app = builder.Build();

app.UseStaticFiles();
app.MapDefaultControllerRoute();
app.MapRazorPages();

var context = app.Services.CreateScope().ServiceProvider.GetRequiredService<DataContext>();
SeedData.SeedDatabase(context);

app.Run();