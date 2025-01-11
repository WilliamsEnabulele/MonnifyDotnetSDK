using MonnifyDotnet.SDK.Models;

namespace MonnifyDotnet.SDK.Interfaces
{
    public interface IRecurringPaymentService
    {
        Task<BaseResponse> ChargeCardToken(ChargeCardTokenRequest request);
    }
}