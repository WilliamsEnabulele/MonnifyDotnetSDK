using MonnifyDotnet.SDK.Models;

namespace MonnifyDotnet.SDK.Interfaces
{
    public interface ITransferService
    {
        Task<BaseResponse<TransferResponse>> InitiateTransfer(InitiateTransferRequest request);

        Task<BaseResponse<TransferResponse>> InitateTransferAsync(InitiateTransferAsyncTransfer request);

        Task<BaseResponse<TransferBulkResponse>> InitiateTransferBulk(InitiateTransferBulkRequest request);

        Task<BaseResponse<TransferResponse>> AuthorizeSingleTransfers(AuthorizeSingleTransferRequest request);

        Task<BaseResponse<TransferBulkResponse>> AuthorizeBulkTransfers(AuthorizeSingleTransferRequest[] requests);

        Task<BaseResponse<ResendOTPResponse>> ResendOTP(ResentOTPRequest request);

        Task<BaseResponse<SingleTransferStatusResponse>> SingleTransferStatus(string reference);

        Task<BaseResponse<SingleTransferListResponse>> ListAllSingleTransfers(BaseFilterRequest request);

        Task<BaseResponse<BulkTransferListResponse>> ListAllBulkTransfers(BaseFilterRequest request);

        Task<BaseResponse<BulkTransferTransactionsResponse>> GetBulkTransferTransactions(BaseFilterRequest request, string batchReference);

        Task<BaseResponse<BulkTransferTransactionsResponse>> BulkTransferStatus(string batchReference);

        Task<BaseResponse<BulkTransferTransactionsResponse>> SearchDisbursementTransactions(SearchDisbursementTransactionsRequest request, string sourceAccountNumber);

        Task<BaseResponse<WalletBalanceResponse>> GetWalletBalance(string accountNumber);
    }
}