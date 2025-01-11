using MonnifyDotnet.SDK.Models;

namespace MonnifyDotnet.SDK.Interfaces
{
    public interface ITransactionService
    {
        Task<BaseResponse<InitiateTransactionResponse>> InitiateTransaction(InitiatizeTransaction request);

        Task<BaseResponse<PayWithBankTransferResponse>> PayWithBankTransfer(PayWithBankTransfer request);

        Task<BaseResponse> PayWithUSSD(PayWithUSSD request);

        Task<BaseResponse<ChargeCardResponse>> ChargeCard(ChargeCard request);

        Task<BaseResponse<AuthorizeOTPResponse>> AuthorizeOTP(AuthorizeOTP request);

        Task<BaseResponse<Authorize3DSCardResponse>> Authorize3DSCard(Authorize3DSCard request);

        Task<BaseResponse<GetAllTransactionsResponse>> GetAllTransactions(GetAllTransactions request);

        Task<BaseResponse<TransactionStatusResponse>> GetTransactionStatus(TransactionStatus request);

        Task<BaseResponse<TransactionStatusResponse>> GetTransactionStatusByReference(TransactionStatusByReference request);
    }
}