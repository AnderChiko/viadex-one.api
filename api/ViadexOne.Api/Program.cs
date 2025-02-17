using ViadexOne.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ConfigureServices(builder.Configuration);

var app = builder.Build();
app.ConfigureApp(builder.Configuration);
app.Run();
