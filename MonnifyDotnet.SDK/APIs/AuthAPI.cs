using MonnifyDotnet.SDK.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace MonnifyDotnet.SDK.APIs
{
    public class AuthAPI
    {
        private static readonly HttpClient _client = new();
        private readonly MonnifyOptions _options;

        public AuthAPI(MonnifyOptions options)
        {
            _options = options;
        }

        public async Task<AuthResponse> GetAccessTokenAsync()
        {
            _client.BaseAddress ??= new Uri(_options.BaseUrl);

            _client.DefaultRequestHeaders.Authorization ??= new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{_options.ApiKey}:{_options.ApiSecret}")));

            var response = await _client.PostAsync("/api/v1/auth/login", null);

            var content = await response.Content.ReadAsStringAsync();

            var authResponse = JsonConvert.DeserializeObject<BaseResponse<AuthResponse>>(content);

            if (!authResponse.RequestSuccessful)
            {
                throw new InvalidOperationException("Failed to authenticate with Monnify.");
            }

            return authResponse.ResponseBody;
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