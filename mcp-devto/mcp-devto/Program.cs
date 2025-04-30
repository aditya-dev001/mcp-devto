using mcp_devto.ToolType;
using Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services
    .AddMcpServer()
    .WithStdioServerTransport()
    .WithTools();

builder.Services.AddHttpClient();
builder.Services.AddScoped<IDevToService, DevToService>();
builder.Services.AddScoped<DevTools>();

// builder.Services.Configure<DevToOptions>(
//     builder.Configuration.GetSection("DevTo")
// );

var app = builder.Build();

app.MapMcp();

app.Run();
