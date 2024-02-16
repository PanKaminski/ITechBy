using Microsoft.Extensions.Options;
using WebApi.Platform;
using WebApi.Platform.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.ConfigureAppsettings();
builder.ConfigureAuth();
builder.Services.AddMediatR(config => 
    config.RegisterServicesFromAssembly(DependencyInjectionExtensions.GetPresentationAssembly()));
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
app.UseCookiePolicy();

var corsSettings = app.Services.GetRequiredService<IOptionsMonitor<CorsSettings>>();

app.UseCors(options =>
{
    options.WithOrigins(corsSettings.CurrentValue.AllowedCorsOrigins)
        .AllowCredentials()
        .AllowAnyHeader()
        .AllowAnyMethod();
});

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
