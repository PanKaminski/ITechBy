using Infrastructure.Implementations.DataMaster;
using Infrastructure.Implementations.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Presentation.Authentication;
using Presentation.Authentication.Commands;
using Services.Abstractions.Account;
using Services.Abstractions.Common;
using Services.Abstractions.Data;
using Services.Abstractions.Data.Repositories;
using Services.Abstractions.Learning;
using Services.Implementations.Account;
using Services.Implementations.Account.Utils;
using Services.Implementations.Common;
using Services.Implementations.Learning;
using Services.Implementations.Utils;
using System.Reflection;
using System.Text;
using WebApi.Platform.Settings;

namespace WebApi.Platform
{
    internal static class DependencyInjectionExtensions
    {
        public static void ConfigureAuth(this WebApplicationBuilder app)
        {
            var jwtSettings = new JwtSettings();
            app.Configuration.GetSection("JwtSettings").Bind(jwtSettings);

            var authBuilder = app.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            });

            authBuilder.AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtSettings.ValidIssuer,
                    ValidAudience = jwtSettings.ValidIssuer,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SecretKey))
                };
            });
        }

        public static Assembly GetPresentationAssembly() => typeof(RegisterHandler).Assembly;

        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IAccountsService, AccountsService>();
            services.AddSingleton<IEmailService, EmailService>();
            services.AddScoped<ISelectItemsService, SelectItemsService>();
            services.AddScoped<AccountToolService>();
            services.AddScoped<ILanguagePartnersService, LanguagePartnersService>();

            return services;
        }

        public static IServiceCollection AddEFCoreContext(this IServiceCollection services, IConfiguration configuration)
        {
            return services.AddDbContext<ITechDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ITechBy")));
        }

        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<IRefreshTokensRepository, RefreshTokensRepository>();
            services.AddScoped<IRolesRepository, RolesRepository>();
            services.AddScoped<ILanguagesRepository, LanguagesRepository>();
            services.AddScoped<ICountriesRepository, CountriesRepository>();
            services.AddScoped<ILanguageLevelsRepository, LanguageLevelsRepository>();

            return services;
        }

        public static void ConfigureAppsettings(this WebApplicationBuilder app)
        {
            app.Services.Configure<CorsSettings>(app.Configuration.GetSection("CorsSettings"));
            app.Services.Configure<JwtSettings>(app.Configuration.GetSection("JwtSettings"));
            app.Services.Configure<EmailSettings>(app.Configuration.GetSection("EmailSettings"));
            app.Services.Configure<SwaggerSettings>(app.Configuration.GetSection("SwaggerSettings"));
        }
    }
}
