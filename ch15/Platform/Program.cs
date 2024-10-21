// Listing 15.21 Creating a logger in the Program.cs file in the Platform folder

using Platform;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

var logger = app.Services.GetRequiredService<ILoggerFactory>().CreateLogger("Pipeline");

logger.LogDebug("Pipleline configuration starting");

app.MapGet("population/{city?}", Population.Endpoint);

logger.LogDebug("Pipleline configuration complete");

app.Run();
