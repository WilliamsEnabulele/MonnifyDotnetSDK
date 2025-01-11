using MonnifyDotnet.SDK.Interfaces;
using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace MonnifyDotnet.SDK.Implementations
{
    public class PaycodeService(BaseService baseService) : IPayCodeService
    {
        private readonly BaseService _baseService = baseService;

        public async Task<BaseResponse<PaycodeResponse>> CreatePaycode(CreatePayCodeRequest request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.PostAsJsonAsync(PayCodeUrls.Paycode, request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<PaycodeResponse>>(content);
        }

        public async Task<BaseResponse<PaycodeResponse>> DeletePaycode(string paycodeReference)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.GetAsync(PayCodeUrls.DeletePaycode.Replace("{{paycodeReference}}", paycodeReference));
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<PaycodeResponse>>(content);
        }

        public async Task<BaseResponse<PayCodesResponse>> FetchPaycodes(FetchPaycodeFilterRequest request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var urlWithParams = $"{PayCodeUrls.Paycode}?{Utilities.ToQueryString(request)}";
            var response = await client.GetAsync(urlWithParams);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<PayCodesResponse>>(content);
        }

        public async Task<BaseResponse<PaycodeResponse>> GetClearPaycode(string paycodeReference)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.GetAsync(PayCodeUrls.GetClearPaycode.Replace("{{paycodeReference}}", paycodeReference));
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<PaycodeResponse>>(content);
        }

        public async Task<BaseResponse<PaycodeResponse>> GetPaycode(string paycodeReference)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.GetAsync(PayCodeUrls.GetPaycode.Replace("{{paycodeReference}}", paycodeReference));
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<PaycodeResponse>>(content);
        }
    }
}