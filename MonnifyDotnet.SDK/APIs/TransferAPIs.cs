using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;

namespace MonnifyDotnet.SDK.APIs
{
    public class TransferAPIs
    {
        private readonly BaseClient _baseClient;

        public TransferAPIs(BaseClient baseClient)
        {
            _baseClient = baseClient;
        }

        public async Task<BaseResponse<TransferBulkResponse>> AuthorizeBulkTransfers(AuthorizeSingleTransferRequest[] requests)
        {
            return await _baseClient.SendAsync<BaseResponse<TransferBulkResponse>>(HttpMethod.Post, TransferUrls.AuthorizeBulkTransfer, requests);
        }

        public async Task<BaseResponse<TransferResponse>> AuthorizeSingleTransfers(AuthorizeSingleTransferRequest request)
        {
            return await _baseClient.SendAsync<BaseResponse<TransferResponse>>(HttpMethod.Post, TransferUrls.AuthorizeSingleTransfer, request);
        }

        public async Task<BaseResponse<BulkTransferTransactionsResponse>> BulkTransferStatus(string batchReference)
        {
            return await _baseClient.SendAsync<BaseResponse<BulkTransferTransactionsResponse>>(HttpMethod.Get, TransferUrls.BulkTransferStatus.Replace("{batchReference}", batchReference));
        }

        public async Task<BaseResponse<BulkTransferTransactionsResponse>> GetBulkTransferTransactions(BaseFilterRequest request, string batchReference)
        {
            var urlWithParams = $"{TransferUrls.BulkTransferStatus.Replace("{batchReference}", batchReference)}?{Utilities.ToQueryString(request)}";
            return await _baseClient.SendAsync<BaseResponse<BulkTransferTransactionsResponse>>(HttpMethod.Get, urlWithParams);
        }

        public async Task<BaseResponse<WalletBalanceResponse>> GetWalletBalance(string accountNumber)
        {
            return await _baseClient.SendAsync<BaseResponse<WalletBalanceResponse>>(HttpMethod.Get, $"{TransferUrls.GetWalletBalance}?accountNumber={accountNumber}");
        }

        public async Task<BaseResponse<TransferResponse>> InitateTransferAsync(InitiateTransferAsyncTransfer request)
        {
            return await _baseClient.SendAsync<BaseResponse<TransferResponse>>(HttpMethod.Post, TransferUrls.InitiateTransfer, request);
        }

        public async Task<BaseResponse<TransferResponse>> InitiateTransfer(InitiateTransferRequest request)
        {
            return await _baseClient.SendAsync<BaseResponse<TransferResponse>>(HttpMethod.Post, TransferUrls.InitiateTransfer, request);
        }

        public async Task<BaseResponse<TransferBulkResponse>> InitiateTransferBulk(InitiateTransferBulkRequest request)
        {
            return await _baseClient.SendAsync<BaseResponse<TransferBulkResponse>>(HttpMethod.Post, TransferUrls.InitiateBulkTransfer, request);
        }

        public async Task<BaseResponse<BulkTransferListResponse>> ListAllBulkTransfers(BaseFilterRequest request)
        {
            return await _baseClient.SendAsync<BaseResponse<BulkTransferListResponse>>(HttpMethod.Get, $"{TransferUrls.ListAllBulkTransfers}?{Utilities.ToQueryString(request)}");
        }

        public async Task<BaseResponse<SingleTransferListResponse>> ListAllSingleTransfers(BaseFilterRequest request)
        {
            return await _baseClient.SendAsync<BaseResponse<SingleTransferListResponse>>(HttpMethod.Get, $"{TransferUrls.ListAllSingleTransfers}?{Utilities.ToQueryString(request)}");
        }

        public async Task<BaseResponse<ResendOTPResponse>> ResendOTP(ResentOTPRequest request)
        {
            return await _baseClient.SendAsync<BaseResponse<ResendOTPResponse>>(HttpMethod.Post, TransferUrls.ResendOTP, request);
        }

        public async Task<BaseResponse<BulkTransferTransactionsResponse>> SearchDisbursementTransactions(SearchDisbursementTransactionsRequest request, string sourceAccountNumber)
        {
            return await _baseClient.SendAsync<BaseResponse<BulkTransferTransactionsResponse>>(HttpMethod.Get, $"{TransferUrls.SearchDisbursementTransactions}?{Utilities.ToQueryString(request)}");
        }

        public async Task<BaseResponse<SingleTransferStatusResponse>> SingleTransferStatus(string reference)
        {
            return await _baseClient.SendAsync<BaseResponse<SingleTransferStatusResponse>>(HttpMethod.Get, $"{TransferUrls.SingleTransferStatus}?reference={reference}");
        }
    }
}