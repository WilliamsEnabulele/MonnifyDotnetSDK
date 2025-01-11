using Microsoft.Extensions.DependencyInjection;
using MonnifyDotnet.SDK.Implementations;
using MonnifyDotnet.SDK.Interfaces;
using MonnifyDotnet.SDK.Models;

namespace MonnifyDotnet.SDK.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddMonnify(this IServiceCollection services, Action<MonnifyOptions> options)
        {
            services.Configure(options);
            services.AddHttpClient("MonnifyClient", client =>
            {
                client.DefaultRequestHeaders.Add("Content-Type", "application/json");
            });

            services.AddScoped<IMonnifyClient, MonnifyClient>();
            return services;
        }
    }
}