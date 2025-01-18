using MonnifyDotnet.SDK.APIs;
using MonnifyDotnet.SDK.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace MonnifyDotnet.SDK.Shared
{
    public class BaseClient
    {
        private readonly HttpClient _client;
        private readonly MonnifyOptions _options;
        private readonly AuthAPI _authService;

        public BaseClient(HttpClient client, MonnifyOptions options)
        {
            _client = client;
            _options = options;
            _authService = new AuthAPI(_options);
        }

        private async Task<HttpClient> GetAuthenticatedClientAsync()
        {
            if (_client.BaseAddress is null)
            {
                var accessToken = await _authService.GetAccessTokenAsync();

                _client.BaseAddress = new Uri(_options.BaseUrl);

                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            }

            return _client;
        }

        public async Task<T> SendAsync<T>(HttpMethod method, string url, object data = null)
        {
            var client = await GetAuthenticatedClientAsync();
            var request = new HttpRequestMessage(method, url)
            {
                Content = data != null
                    ? new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json")
                    : null
            };

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }

        public Task<T> GetAsync<T>(string url) => SendAsync<T>(HttpMethod.Get, url);

        public Task<T> PostAsync<T>(string url, object data) => SendAsync<T>(HttpMethod.Post, url, data);

        public Task<T> PutAsync<T>(string url, object data) => SendAsync<T>(HttpMethod.Put, url, data);

        public Task DeleteAsync(string url) => SendAsync<object>(HttpMethod.Delete, url);
    }
}