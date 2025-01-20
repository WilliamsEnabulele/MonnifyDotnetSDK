using Microsoft.Extensions.DependencyInjection;
using MonnifyDotnet.SDK.Models;

namespace MonnifyDotnet.SDK.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddMonnify(this IServiceCollection services, Action<MonnifyOptions> options)
        {
            services.Configure(options);
            services.AddHttpClient<IMonnifyClient, MonnifyClient>("MonnifyClient");

            return services;
        }
    }
}