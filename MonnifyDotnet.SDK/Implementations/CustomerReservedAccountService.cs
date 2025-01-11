using MonnifyDotnet.SDK.Interfaces;
using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace MonnifyDotnet.SDK.Implementations
{
    public class CustomerReservedAccountService : ICustomerReservedAccountService
    {
        private readonly BaseService _baseService;

        public CustomerReservedAccountService(BaseService baseService)
        {
            _baseService = baseService;
        }

        /// <summary>
        /// This endpoint links accounts with another partner bank to an existing customer.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="accountReference"></param>
        /// <returns></returns>
        public async Task<BaseResponse> AddLinkedAccount(AddLinkedAccountRequest request, string accountReference)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.PutAsJsonAsync(CustomerReservedAccountUrls.AddLinkedAccount.Replace("{accountReference}", accountReference), request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse>(content);
        }

        /// <summary>
        /// This endpoint allows the creation of dedicated virtual accounts for your customers.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<ReservedAccountResponse>> CreateReservedAccount(ReservedAccountRequest request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.PostAsJsonAsync(CustomerReservedAccountUrls.CreateReservedAccountGeneral, request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<ReservedAccountResponse>>(content);
        }

        /// <summary>
        /// This endpoint allows the creation of an invoiced reserved account.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>

        public async Task<BaseResponse> CreateReservedAccountInvoice(CreateReservedAccountInvoiceRequest request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.PostAsJsonAsync(CustomerReservedAccountUrls.CreateReservedAccountInvoice, request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse>(content);
        }

        /// <summary>
        /// This endpoint allows you to deallocate/delete already created a reserved account.
        /// </summary>
        /// <param name="accountReference"></param>
        /// <returns></returns>
        public async Task<BaseResponse> DealloacteReserveAccount(string accountReference)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.DeleteAsync(CustomerReservedAccountUrls.DeallocatingAReservedAccount.Replace("{accountReference}", accountReference));
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse>(content);
        }

        /// <summary>
        /// This endpoint returns details of an account reserved for a customer
        /// </summary>
        /// <param name="accountReference"></param>
        /// <returns></returns>
        public async Task<BaseResponse<ReservedAccountResponse>> GetReservedAccountDetails(string accountReference)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.GetAsync(CustomerReservedAccountUrls.GetReservedAccountDetails.Replace("{accountReference}", accountReference));
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<ReservedAccountResponse>>(content);
        }

        /// <summary>
        /// This endpoint returns the list of all transactions done on a reserved account.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<ReservedAccountTransactionsResponse>> GetReservedAccountTransactions(ReservedAccountTransactionsRequest request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var urlWithParams = $"{CustomerReservedAccountUrls.GetReservedAccountTransactions}?{Utilities.ToQueryString(request)}";
            var response = await client.GetAsync(urlWithParams);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<ReservedAccountTransactionsResponse>>(content);
        }

        /// <summary>
        /// This endpoint updates the split config of a customer reserved account.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="accountReference"></param>
        /// <returns></returns>
        public async Task<BaseResponse<SplitConfigForReservedAccountResponse>> SplitConfigForReservedAccount(SplitConfigForReservedAccountRequest request, string accountReference)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.PutAsJsonAsync(CustomerReservedAccountUrls.UpdatingSplitConfigForReservedAccount.Replace("{accountReference}", accountReference), request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<SplitConfigForReservedAccountResponse>>(content);
        }

        /// <summary>
        /// This endpoint manages accounts that can fund a reserved account using either BVNs, Account Name or Account Number.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="accountReference"></param>
        /// <returns></returns>

        public async Task<BaseResponse<AllowedPaymentSourcesResponse>> UpdateAllowedPaymentSource(AllowedPaymentSourceRequest request, string accountReference)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.PutAsJsonAsync(CustomerReservedAccountUrls.AllowedPaymentSource.Replace("{accountReference}", accountReference), request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<AllowedPaymentSourcesResponse>>(content);
        }

        /// <summary>
        /// This endpoint updates BVN of customers reserved account
        /// </summary>
        /// <param name="request"></param>
        /// <param name="accountReference"></param>
        /// <returns></returns>
        public async Task<BaseResponse> UpdateBVNForReserveAccount(UpdateBVNForReservedAccountRequest request, string accountReference)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.PutAsJsonAsync(CustomerReservedAccountUrls.UpdateBVNForAReserveAccount.Replace("{accountReference}", accountReference), request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse>(content);
        }

        /// <summary>
        /// This endpoint links customers' BVN/NIN to their respective reserved accounts.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="accountReference"></param>
        /// <returns></returns>

        public async Task<BaseResponse<UpdateKYCInfoResponse>> UpdateKYCInfo(UpdateKYCInfoRequest request, string accountReference)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.PutAsJsonAsync(CustomerReservedAccountUrls.UpdateKYCInfo.Replace("{accountReference}", accountReference), request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<UpdateKYCInfoResponse>>(content);
        }
    }
}