using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;

namespace MonnifyDotnet.SDK.APIs
{
    public class PaycodeAPIs
    {
        private readonly BaseClient _baseClient;

        public PaycodeAPIs(BaseClient baseClient)
        {
            _baseClient = baseClient;
        }

        public async Task<BaseResponse<PaycodeResponse>> CreatePaycode(CreatePayCodeRequest request)
        {
            return await _baseClient.SendAsync<BaseResponse<PaycodeResponse>>(HttpMethod.Post, PayCodeUrls.Paycode, request);
        }

        public async Task<BaseResponse<PaycodeResponse>> DeletePaycode(string paycodeReference)
        {
            return await _baseClient.SendAsync<BaseResponse<PaycodeResponse>>(HttpMethod.Get, PayCodeUrls.DeletePaycode.Replace("{{paycodeReference}}", paycodeReference));
        }

        public async Task<BaseResponse<PayCodesResponse>> FetchPaycodes(FetchPaycodeFilterRequest request)
        {
            var urlWithParams = $"{PayCodeUrls.Paycode}?{Utilities.ToQueryString(request)}";
            return await _baseClient.SendAsync<BaseResponse<PayCodesResponse>>(HttpMethod.Get, urlWithParams);
        }

        public async Task<BaseResponse<PaycodeResponse>> GetClearPaycode(string paycodeReference)
        {
            return await _baseClient.SendAsync<BaseResponse<PaycodeResponse>>(HttpMethod.Get, PayCodeUrls.GetClearPaycode.Replace("{{paycodeReference}}", paycodeReference));
        }

        public async Task<BaseResponse<PaycodeResponse>> GetPaycode(string paycodeReference)
        {
            return await _baseClient.SendAsync<BaseResponse<PaycodeResponse>>(HttpMethod.Get, PayCodeUrls.GetPaycode.Replace("{{paycodeReference}}", paycodeReference));
        }
    }
}