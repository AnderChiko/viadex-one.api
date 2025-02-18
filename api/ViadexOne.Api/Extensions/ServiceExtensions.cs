using ViadexOne.Core;

namespace ViadexOne.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            services.AddLogging();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            services.AddOpenApi();

            services.AddCoreServices();

            services.AddCors(options =>
             {
                 options.AddPolicy("AllowSpecificOrigin",
                     policy => policy.WithOrigins("http://localhost:8080")  // Add your allowed origins
                                     .AllowAnyHeader()
                                     .AllowAnyMethod());
             });

            return services;
        }
    }
}
