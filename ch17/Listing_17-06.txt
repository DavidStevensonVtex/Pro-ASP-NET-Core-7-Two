// Listing 17.6 Adding a cache service in the Program.cs file in the Platform folder

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDistributedMemoryCache(opts =>
{
	opts.SizeLimit = 200;
});

var app = builder.Build();

app.MapEndpoint<Platform.SumEndpoint>("/sum/{count:int=2000000000}");

app.MapGet("/", async context =>
{
	await context.Response.WriteAsync("Hello World!");
});

app.Run();
