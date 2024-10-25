// Listing 17.4 Adding an endpoint in the Program.cs file in the Platform folder

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDistributedMemoryCache();

var app = builder.Build();

app.MapEndpoint<Platform.SumEndpoint>("/sum/{count:int=2000000000}");

app.MapGet("/", async context =>
{
	await context.Response.WriteAsync("Hello World!");
});

app.Run();
