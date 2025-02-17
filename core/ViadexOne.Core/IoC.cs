using Microsoft.Extensions.DependencyInjection;
using ViadexOne.Core.Services;

namespace ViadexOne.Core
{
    /// <summary>
    /// Method to register the Core dependencies.
    /// 
    /// Transient: A new instance of the type is used every time the type is requested.
    /// 
    /// Scoped: A new instance of the type is created the first time it’s requested within
    ///			a given HTTP request, and then re - used for all subsequent types resolved
    ///			during that HTTP

    /// <summary>
    ///    inversion of control
    /// </summary>
    public static class IoC
    {

        /// <summary>
        ///   inject app setting configurations
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            services.AddScoped<ITelemetryService, TelemetryService>();

            return services;
        }
    }
}
