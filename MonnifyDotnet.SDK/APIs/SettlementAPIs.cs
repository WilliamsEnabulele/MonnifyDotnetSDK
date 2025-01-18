using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;

namespace MonnifyDotnet.SDK.APIs
{
    public class SettlementAPIs
    {
        private readonly BaseClient _baseClient;

        public SettlementAPIs(BaseClient baseClient)
        {
            _baseClient = baseClient;
        }

        /// <summary>
        /// This endpoint returns settlement information on transactions made to your settlement account.
        /// </summary>
        /// <param name="transactionReference"></param>
        /// <returns></returns>
        public async Task<BaseResponse<SettlementInformationForTransactionResponse>> GetSettlementInformationForTransaction(string transactionReference)
        {
            return await _baseClient.SendAsync<BaseResponse<SettlementInformationForTransactionResponse>>(HttpMethod.Get, $"{SettlementUrls.GetSettlementsInformation}?transactionReference={transactionReference}");
        }

        /// <summary>
        /// This endpoint returns all transactions that made up a settlement.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<SettlementResponse>> GetTransactionsBySettlementReference(SettlementFilterRequest request)
        {
            var urlWithParams = $"{SettlementUrls.GetTransactionsBySettlementReference}?{Utilities.ToQueryString(request)}";
            return await _baseClient.SendAsync<BaseResponse<SettlementResponse>>(HttpMethod.Get, urlWithParams);
        }
    }
}