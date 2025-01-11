using MonnifyDotnet.SDK.Interfaces;
using MonnifyDotnet.SDK.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace MonnifyDotnet.SDK.Implementations
{
    public class AuthService(HttpClient client, MonnifyOptions options) : IAuthService
    {
        private readonly HttpClient _client = client;
        private readonly MonnifyOptions _options = options;
        private string? _accessToken;
        private DateTime _tokenExpiry;

        public async Task<string> GetAccessTokenAsync()
        {
            if (!string.IsNullOrEmpty(_accessToken) && DateTime.UtcNow < _tokenExpiry)
            {
                return _accessToken;
            }

            _client.BaseAddress = new Uri(_options.BaseUrl);
            var credentials = $"{_options.ApiKey}:{_options.ApiSecret}";
            var encodedCredentials = Convert.ToBase64String(Encoding.UTF8.GetBytes(credentials));

            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encodedCredentials);

            var response = await _client.PostAsync("/api/v1/auth/login", null);

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var authResponse = JsonConvert.DeserializeObject<AuthResponse>(content);

            if (authResponse == null || string.IsNullOrEmpty(authResponse.AccessToken))
            {
                throw new InvalidOperationException("Failed to authenticate with Monnify.");
            }

            _accessToken = authResponse.AccessToken;
            _tokenExpiry = DateTime.UtcNow.AddSeconds(authResponse.ExpiresIn - 60);

            return _accessToken;
        }
    }

    public class AuthResponse
    {
        public string AccessToken { get; set; } = string.Empty;
        public int ExpiresIn { get; set; }
    }
}