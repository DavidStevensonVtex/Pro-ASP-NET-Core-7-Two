// Listing 17.13 Using a persistent data cache in the Program.cs file in the Platform folder

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddDistributedMemoryCache(opts =>
//{
//	opts.SizeLimit = 200;
//});

builder.Services.AddDistributedSqlServerCache(opts =>
{
	opts.ConnectionString = builder.Configuration["ConnectionStrings:CacheConnection"];
	opts.SchemaName = "dbo";
	opts.TableName = "DataCache";
});

var app = builder.Build();

app.MapEndpoint<Platform.SumEndpoint>("/sum/{count:int=2000000000}");

app.MapGet("/", async context =>
{
	await context.Response.WriteAsync("Hello World!");
});

app.Run();
