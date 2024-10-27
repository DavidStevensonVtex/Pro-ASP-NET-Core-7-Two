// Listing 17.17 Using output caching in the Program.cs file in the Platform folder

using Platform.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOutputCache();

builder.Services.AddSingleton<IResponseFormatter, HtmlResponseFormatter>();

var app = builder.Build();

app.UseOutputCache();

app.MapEndpoint<Platform.SumEndpoint>("/sum/{count:int=2000000000}")
	.CacheOutput();

app.MapGet("/", async context =>
{
	await context.Response.WriteAsync("Hello World!");
});

app.Run();
