using MonnifyDotnet.SDK.Interfaces;
using MonnifyDotnet.SDK.Models;
using System.Net.Http.Headers;

namespace MonnifyDotnet.SDK.Implementations
{
    public class BaseService
    {
        private readonly HttpClient _client;
        private readonly MonnifyOptions _options;
        private readonly IAuthService _authService;

        public BaseService(HttpClient client, IAuthService authService, MonnifyOptions options)
        {
            _client = new HttpClient();
            _options = options;
            _authService = authService;
        }

        public async Task<HttpClient> GetAuthenticatedClientAsync()
        {
            var accessToken = await _authService.GetAccessTokenAsync();

            _client.BaseAddress = new Uri(_options.BaseUrl);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            return _client;
        }
    }
}