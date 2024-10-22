// Listing 16.17 Returning an error response in the Program.cs file in the Platform folder

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

if (! app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/error.html");
	app.UseStaticFiles();
}

app.Run(context =>
{
	throw new Exception("Something has gone wrong");
});

app.Run();
