using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;

namespace MonnifyDotnet.SDK.APIs
{
    public class VerificationAPIs
    {
        private readonly BaseClient _baseClient;

        public VerificationAPIs(BaseClient baseClient)
        {
            _baseClient = baseClient;
        }

        public async Task<BaseResponse<ValidateBankAccountResponse>> ValidateBankAccount(string accountNumber, string bankCode)
        {
            var urlWithParams = $"{VerificationUrls.ValidateBankAccount}?accountNumber={accountNumber}&bankCode={bankCode}";
            return await _baseClient.SendAsync<BaseResponse<ValidateBankAccountResponse>>(HttpMethod.Get, urlWithParams);
        }

        public async Task<BaseResponse> VerifyBVN(BVNInformationVerificationRequest request)
        {
            return await _baseClient.SendAsync<BaseResponse>(HttpMethod.Post, VerificationUrls.BVNInformationVerification, request);
        }

        public async Task<BaseResponse<BVNAndAccountNameMatchResponse>> VerifyBVNAndACcountNameMatch(BVNAndAccountNameMatchRequest request)
        {
            return await _baseClient.SendAsync<BaseResponse<BVNAndAccountNameMatchResponse>>(HttpMethod.Post, VerificationUrls.BVNAndAccountNameMatch, request);
        }

        public async Task<BaseResponse<NINVerificationResponse>> VerifyNIN(NINVerificationRequest request)
        {
            return await _baseClient.SendAsync<BaseResponse<NINVerificationResponse>>(HttpMethod.Post, VerificationUrls.NINVerification, request);
        }
    }
}