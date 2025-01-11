using MonnifyDotnet.SDK.Interfaces;
using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;
using Newtonsoft.Json;

namespace MonnifyDotnet.SDK.Implementations
{
    public class SettlementService(BaseService baseService) : ISettlementService
    {
        private readonly BaseService _baseService = baseService;

        /// <summary>
        /// This endpoint returns settlement information on transactions made to your settlement account.
        /// </summary>
        /// <param name="transactionReference"></param>
        /// <returns></returns>
        public async Task<BaseResponse<SettlementInformationForTransactionResponse>> GetSettlementInformationForTransaction(string transactionReference)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.GetAsync($"{SettlementUrls.GetSettlementsInformation}?transactionReference={transactionReference}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<SettlementInformationForTransactionResponse>>(content);
        }

        /// <summary>
        /// This endpoint returns all transactions that made up a settlement.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<SettlementResponse>> GetTransactionsBySettlementReference(SettlementFilterRequest request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var urlWithParams = $"{SettlementUrls.GetTransactionsBySettlementReference}?{Utilities.ToQueryString(request)}";
            var response = await client.GetAsync(urlWithParams);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<SettlementResponse>>(content);
        }
    }
}