using MonnifyDotnet.SDK.Models;

namespace MonnifyDotnet.SDK.Interfaces
{
    public interface ISettlementService
    {
        Task<BaseResponse<SettlementResponse>> GetTransactionsBySettlementReference(SettlementFilterRequest request);

        Task<BaseResponse<SettlementInformationForTransactionResponse>> GetSettlementInformationForTransaction(string transactionReference);
    }
}