using MonnifyDotnet.SDK.Models;

namespace MonnifyDotnet.SDK.Interfaces
{
    public interface IPayCodeService
    {
        Task<BaseResponse<PaycodeResponse>> CreatePaycode(CreatePayCodeRequest request);

        Task<BaseResponse<PaycodeResponse>> GetPaycode(string paycodeReference);

        Task<BaseResponse<PaycodeResponse>> GetClearPaycode(string paycodeReference);

        Task<BaseResponse<PayCodesResponse>> FetchPaycodes(FetchPaycodeFilterRequest request);

        Task<BaseResponse<PaycodeResponse>> DeletePaycode(string paycodeReference);
    }
}