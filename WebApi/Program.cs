using Microsoft.Extensions.Options;
using System.Reflection;
using WebApi.Platform;
using WebApi.Platform.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.ConfigureAuth();
builder.ConfigureAppsettings();
builder.Services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
builder.Services.AddEFCoreContext(builder.Configuration);
builder.Services.AddInfrastructure();
builder.Services.AddCoreServices();
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
var swaggerSettings = app.Services.GetRequiredService<IOptionsMonitor<SwaggerSettings>>();
if (app.Environment.IsDevelopment() && swaggerSettings.CurrentValue.SwaggerOn)
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
