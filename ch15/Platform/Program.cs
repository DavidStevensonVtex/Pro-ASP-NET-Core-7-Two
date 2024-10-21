// Listing 15.18 Configuring the application in the Program.cs file in the Platform folder

using Platform;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("population/{city?}", Population.Endpoint);

app.Run();
