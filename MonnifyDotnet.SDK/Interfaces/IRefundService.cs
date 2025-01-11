using MonnifyDotnet.SDK.Models;

namespace MonnifyDotnet.SDK.Interfaces
{
    public interface IRefundService
    {
        Task<BaseResponse<RefundResponse>> InitiateRefund(InitiateRefundRequest refundRequest);

        Task<BaseResponse<RefundResponse>> GetRefundStatus(string refundReference);

        Task<BaseResponse<RefundsResponse>> GetAllRefunds(int page, int size);
    }
}