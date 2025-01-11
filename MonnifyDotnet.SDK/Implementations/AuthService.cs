using MonnifyDotnet.SDK.Interfaces;
using MonnifyDotnet.SDK.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace MonnifyDotnet.SDK.Implementations
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _client;
        private readonly MonnifyOptions _options;
        private string? _accessToken;
        private DateTime _tokenExpiry;

        public AuthService(MonnifyOptions options)
        {
            _client = new HttpClient();
            _options = options;
        }

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

            var content = await response.Content.ReadAsStringAsync();

            var authResponse = JsonConvert.DeserializeObject<BaseResponse<AuthResponse>>(content);

            if (!authResponse.RequestSuccessful)
            {
                throw new InvalidOperationException("Failed to authenticate with Monnify.");
            }

            _accessToken = authResponse.ResponseBody.AccessToken;

            _tokenExpiry = DateTime.UtcNow.AddSeconds(authResponse.ResponseBody.ExpiresIn - 60);

            return _accessToken;
        }
    }

    public class AuthResponse
    {
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; } = string.Empty;
        [JsonProperty("expiresIn")]
        public int ExpiresIn { get; set; }
    }
}