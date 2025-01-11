using MonnifyDotnet.SDK.Models;

namespace MonnifyDotnet.SDK.Interfaces
{
    public interface IVerificationService
    {
        Task<BaseResponse<ValidateBankAccountResponse>> ValidateBankAccount(string accountNumber, string bankCode);

        Task<BaseResponse> VerifyBVN(BVNInformationVerificationRequest request);

        Task<BaseResponse<BVNAndAccountNameMatchResponse>> VerifyBVNAndACcountNameMatch(BVNAndAccountNameMatchRequest request);

        Task<BaseResponse<NINVerificationResponse>> VerifyNIN(NINVerificationRequest request);
    }
}