using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;

namespace MonnifyDotnet.SDK.APIs
{
    public class CustomerReservedAccountAPIs
    {
        private readonly BaseClient _baseClient;

        public CustomerReservedAccountAPIs(BaseClient baseClient)
        {
            _baseClient = baseClient;
        }

        /// <summary>
        /// This endpoint links accounts with another partner bank to an existing customer.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="accountReference"></param>
        /// <returns></returns>
        public async Task<BaseResponse> AddLinkedAccount(AddLinkedAccountRequest request, string accountReference)
        {
            var url = CustomerReservedAccountUrls.AddLinkedAccount.Replace("{accountReference}", accountReference);
            return await _baseClient.SendAsync<BaseResponse>(HttpMethod.Put, url, request);
        }

        /// <summary>
        /// This endpoint allows the creation of dedicated virtual accounts for your customers.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<ReservedAccountResponse>> CreateReservedAccount(ReservedAccountRequest request)
        {
            return await _baseClient.SendAsync<BaseResponse<ReservedAccountResponse>>(HttpMethod.Post, CustomerReservedAccountUrls.CreateReservedAccountGeneral, request);
        }

        /// <summary>
        /// This endpoint allows the creation of an invoiced reserved account.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>

        public async Task<BaseResponse> CreateReservedAccountInvoice(CreateReservedAccountInvoiceRequest request)
        {
            return await _baseClient.SendAsync<BaseResponse>(HttpMethod.Post, CustomerReservedAccountUrls.CreateReservedAccountInvoice, request);
        }

        /// <summary>
        /// This endpoint allows you to deallocate/delete already created a reserved account.
        /// </summary>
        /// <param name="accountReference"></param>
        /// <returns></returns>
        public async Task<BaseResponse> DealloacteReserveAccount(string accountReference)
        {
            return await _baseClient.SendAsync<BaseResponse>(HttpMethod.Delete, CustomerReservedAccountUrls.DeallocatingAReservedAccount.Replace("{accountReference}", accountReference));
        }

        /// <summary>
        /// This endpoint returns details of an account reserved for a customer
        /// </summary>
        /// <param name="accountReference"></param>
        /// <returns></returns>
        public async Task<BaseResponse<ReservedAccountResponse>> GetReservedAccountDetails(string accountReference)
        {
            return await _baseClient.SendAsync<BaseResponse<ReservedAccountResponse>>(HttpMethod.Get, CustomerReservedAccountUrls.GetReservedAccountDetails.Replace("{accountReference}", accountReference));
        }

        /// <summary>
        /// This endpoint returns the list of all transactions done on a reserved account.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<ReservedAccountTransactionsResponse>> GetReservedAccountTransactions(ReservedAccountTransactionsRequest request)
        {
            var urlWithParams = $"{CustomerReservedAccountUrls.GetReservedAccountTransactions}?{Utilities.ToQueryString(request)}";
            return await _baseClient.SendAsync<BaseResponse<ReservedAccountTransactionsResponse>>(HttpMethod.Get, urlWithParams);
        }

        /// <summary>
        /// This endpoint updates the split config of a customer reserved account.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="accountReference"></param>
        /// <returns></returns>
        public async Task<BaseResponse<SplitConfigForReservedAccountResponse>> SplitConfigForReservedAccount(SplitConfigForReservedAccountRequest request, string accountReference)
        {
            var url = CustomerReservedAccountUrls.UpdatingSplitConfigForReservedAccount.Replace("{accountReference}", accountReference);
            return await _baseClient.SendAsync<BaseResponse<SplitConfigForReservedAccountResponse>>(HttpMethod.Put, url, request);
        }

        /// <summary>
        /// This endpoint manages accounts that can fund a reserved account using either BVNs, Account Name or Account Number.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="accountReference"></param>
        /// <returns></returns>

        public async Task<BaseResponse<AllowedPaymentSourcesResponse>> UpdateAllowedPaymentSource(AllowedPaymentSourceRequest request, string accountReference)
        {
            return await _baseClient.SendAsync<BaseResponse<AllowedPaymentSourcesResponse>>(HttpMethod.Put, CustomerReservedAccountUrls.AllowedPaymentSource.Replace("{accountReference}", accountReference), request);
        }

        /// <summary>
        /// This endpoint updates BVN of customers reserved account
        /// </summary>
        /// <param name="request"></param>
        /// <param name="accountReference"></param>
        /// <returns></returns>
        public async Task<BaseResponse> UpdateBVNForReserveAccount(UpdateBVNForReservedAccountRequest request, string accountReference)
        {
            var url = CustomerReservedAccountUrls.UpdateBVNForAReserveAccount.Replace("{accountReference}", accountReference);
            return await _baseClient.SendAsync<BaseResponse>(HttpMethod.Put, url, request);
        }

        /// <summary>
        /// This endpoint links customers' BVN/NIN to their respective reserved accounts.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="accountReference"></param>
        /// <returns></returns>

        public async Task<BaseResponse<UpdateKYCInfoResponse>> UpdateKYCInfo(UpdateKYCInfoRequest request, string accountReference)
        {
            return await _baseClient.SendAsync<BaseResponse<UpdateKYCInfoResponse>>(HttpMethod.Put, CustomerReservedAccountUrls.UpdateKYCInfo.Replace("{accountReference}", accountReference), request);
        }
    }
}