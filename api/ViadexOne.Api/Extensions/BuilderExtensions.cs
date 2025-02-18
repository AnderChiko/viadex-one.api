using ViadexOne.Core.Middleware;

namespace ViadexOne.Api.Extensions
{
    public static class BuilderExtensions
    {
        public static WebApplication ConfigureApp(this WebApplication app, IConfiguration configuration)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }
            app.UseCors("AllowSpecificOrigin");
            app.UseHttpsRedirection();

            app.UseMiddleware<ErrorHandlingMiddleware>(); // Add custom middleware
        
            app.UseAuthorization();

            app.MapControllers();

            app.UseSwaggerUI(options =>
            {
                options.RoutePrefix = "";
                options.SwaggerEndpoint("openapi/v1.json", "Viadex Api");
            });

            return app;
        }

    }
}
