using MonnifyDotnet.SDK.Models;

namespace MonnifyDotnet.SDK.Interfaces
{
    public interface ISubAccountService
    {
        Task<BaseResponse<SubAccountResponse>> CreateSubAccount(CreateSubAccountRequest[] requests);

        Task<BaseResponse> DeleteSubAccount(string sunAccountCode);

        Task<BaseResponse<SubAccountResponse[]>> GetSubAccounts();

        Task<BaseResponse<SubAccountResponse>> UpdateSubAccount(UpdateSubAccountRequest request);
    }
}