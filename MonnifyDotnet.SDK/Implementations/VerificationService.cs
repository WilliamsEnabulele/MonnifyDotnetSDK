using MonnifyDotnet.SDK.Interfaces;
using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace MonnifyDotnet.SDK.Implementations
{
    public class VerificationService(BaseService baseService) : IVerificationService
    {
        private readonly BaseService _baseService = baseService;

        public async Task<BaseResponse<ValidateBankAccountResponse>> ValidateBankAccount(string accountNumber, string bankCode)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var urlWithParams = $"{VerificationUrls.ValidateBankAccount}?accountNumber={accountNumber}&bankCode={bankCode}";
            var response = await client.GetAsync(urlWithParams);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<ValidateBankAccountResponse>>(content);
        }

        public async Task<BaseResponse> VerifyBVN(BVNInformationVerificationRequest request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.PostAsJsonAsync(VerificationUrls.BVNInformationVerification, request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse>(content);
        }

        public async Task<BaseResponse<BVNAndAccountNameMatchResponse>> VerifyBVNAndACcountNameMatch(BVNAndAccountNameMatchRequest request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.PostAsJsonAsync(VerificationUrls.BVNAndAccountNameMatch, request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<BVNAndAccountNameMatchResponse>>(content);
        }

        public async Task<BaseResponse<NINVerificationResponse>> VerifyNIN(NINVerificationRequest request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.PostAsJsonAsync(VerificationUrls.NINVerification, request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<NINVerificationResponse>>(content);
        }
    }
}