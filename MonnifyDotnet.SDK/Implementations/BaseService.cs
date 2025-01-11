using MonnifyDotnet.SDK.Interfaces;
using MonnifyDotnet.SDK.Models;
using System.Net.Http.Headers;

namespace MonnifyDotnet.SDK.Implementations
{
    public class BaseService(HttpClient client, IAuthService authService, MonnifyOptions options)
    {
        private readonly HttpClient _client = client;
        private readonly MonnifyOptions _options = options;

        public async Task<HttpClient> GetAuthenticatedClientAsync()
        {
            var accessToken = await authService.GetAccessTokenAsync();

            _client.BaseAddress = new Uri(_options.BaseUrl);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            return _client;
        }
    }
}