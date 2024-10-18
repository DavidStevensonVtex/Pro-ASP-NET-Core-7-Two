// Listing 13.28 Adding a middleware component in the Program.cs file in the Platform folder

using Platform;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<RouteOptions>(opts =>
{
	opts.ConstraintMap.Add("countryName", typeof(CountryRouteConstraint));
});

var app = builder.Build();

// Use app.Run when your middleware never calls next:
app.Run(async (context) =>
{
	Endpoint? end = context.GetEndpoint();
	if (end != null)
	{
		await context.Response.WriteAsync($"{end.DisplayName} Selected \n");
	}
	else
	{
		await context.Response.WriteAsync("No Endpoint Selected \n");
	}
});

app.Map("{number:int}", async context =>
{
	await context.Response.WriteAsync("Routed to the int endpoint");
})
	.WithDisplayName("Int Endpoint")
	.Add(b => ((RouteEndpointBuilder)b).Order = 1);

app.Map("{number:double}", async context =>
{
	await context.Response.WriteAsync("Routed to the double endpoint");
})
	.WithDisplayName("Double Endpoint")
	.Add(b => ((RouteEndpointBuilder)b).Order = 2);

app.MapFallback(async context =>
{
	await context.Response.WriteAsync("Routed to fallback endpoint");
});

app.Run();
