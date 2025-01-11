using MonnifyDotnet.SDK.Interfaces;
using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace MonnifyDotnet.SDK.Implementations
{
    public class TransferService : ITransferService
    {
        private readonly BaseService _baseService;

        public TransferService(BaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<BaseResponse<TransferBulkResponse>> AuthorizeBulkTransfers(AuthorizeSingleTransferRequest[] requests)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.PostAsJsonAsync(TransferUrls.AuthorizeBulkTransfer, requests);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<TransferBulkResponse>>(content);
        }

        public async Task<BaseResponse<TransferResponse>> AuthorizeSingleTransfers(AuthorizeSingleTransferRequest request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.PostAsJsonAsync(TransferUrls.AuthorizeSingleTransfer, request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<TransferResponse>>(content);
        }

        public async Task<BaseResponse<BulkTransferTransactionsResponse>> BulkTransferStatus(string batchReference)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.GetAsync(TransferUrls.BulkTransferStatus.Replace("{batchReference}", batchReference));
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<BulkTransferTransactionsResponse>>(content);
        }

        public async Task<BaseResponse<BulkTransferTransactionsResponse>> GetBulkTransferTransactions(BaseFilterRequest request, string batchReference)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var urlWithParams = $"{TransferUrls.BulkTransferStatus.Replace("{batchReference}", batchReference)}?{Utilities.ToQueryString(request)}";
            var response = await client.GetAsync(urlWithParams);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<BulkTransferTransactionsResponse>>(content);
        }

        public async Task<BaseResponse<WalletBalanceResponse>> GetWalletBalance(string accountNumber)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.GetAsync($"{TransferUrls.GetWalletBalance}?accountNumber={accountNumber}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<WalletBalanceResponse>>(content);
        }

        public async Task<BaseResponse<TransferResponse>> InitateTransferAsync(InitiateTransferAsyncTransfer request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.PostAsJsonAsync(TransferUrls.InitiateTransfer, request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<TransferResponse>>(content);
        }

        public async Task<BaseResponse<TransferResponse>> InitiateTransfer(InitiateTransferRequest request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.PostAsJsonAsync(TransferUrls.InitiateTransfer, request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<TransferResponse>>(content);
        }

        public async Task<BaseResponse<TransferBulkResponse>> InitiateTransferBulk(InitiateTransferBulkRequest request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.PostAsJsonAsync(TransferUrls.InitiateBulkTransfer, request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<TransferBulkResponse>>(content);
        }

        public async Task<BaseResponse<BulkTransferListResponse>> ListAllBulkTransfers(BaseFilterRequest request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.GetAsync($"{TransferUrls.ListAllBulkTransfers}?{Utilities.ToQueryString(request)}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<BulkTransferListResponse>>(content);
        }

        public async Task<BaseResponse<SingleTransferListResponse>> ListAllSingleTransfers(BaseFilterRequest request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.GetAsync($"{TransferUrls.ListAllSingleTransfers}?{Utilities.ToQueryString(request)}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<SingleTransferListResponse>>(content);
        }

        public async Task<BaseResponse<ResendOTPResponse>> ResendOTP(ResentOTPRequest request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.PostAsJsonAsync(TransferUrls.ResendOTP, request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<ResendOTPResponse>>(content);
        }

        public async Task<BaseResponse<BulkTransferTransactionsResponse>> SearchDisbursementTransactions(SearchDisbursementTransactionsRequest request, string sourceAccountNumber)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.GetAsync($"{TransferUrls.SearchDisbursementTransactions}?{Utilities.ToQueryString(request)}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<BulkTransferTransactionsResponse>>(content);
        }

        public async Task<BaseResponse<SingleTransferStatusResponse>> SingleTransferStatus(string reference)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.GetAsync($"{TransferUrls.SingleTransferStatus}?reference={reference}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<SingleTransferStatusResponse>>(content);
        }
    }
}