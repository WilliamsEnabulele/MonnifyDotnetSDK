using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;

namespace MonnifyDotnet.SDK.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddMonnify(this IServiceCollection services, Action<MonnifyOptions> options)
        {
            services.Configure(options);
            services.AddHttpClient();

            services.AddSingleton<BaseClient>(
                sp =>
                {
                    var httpClientFactory = sp.GetRequiredService<IHttpClientFactory>();
                    var client = httpClientFactory.CreateClient();
                    var options = sp.GetRequiredService<IOptions<MonnifyOptions>>().Value;
                    client.BaseAddress = new Uri(options.BaseUrl);

                    return new BaseClient(client, options);
                });

            services.AddScoped<IMonnifyClient, MonnifyClient>();

            return services;
        }
    }
}