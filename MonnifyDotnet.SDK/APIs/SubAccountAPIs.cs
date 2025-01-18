using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;

namespace MonnifyDotnet.SDK.APIs
{
    public class SubAccountAPIs
    {
        private readonly BaseClient _baseClient;

        public SubAccountAPIs(BaseClient baseClient)
        {
            _baseClient = baseClient;
        }

        /// <summary>
        /// This endpoint allows you to create a sub account to enable the spliting of payments between different accounts.
        /// </summary>
        /// <param name="requests"></param>
        /// <returns></returns>
        public async Task<BaseResponse<SubAccountResponse>> CreateSubAccount(CreateSubAccountRequest[] requests)
        {
            return await _baseClient.SendAsync<BaseResponse<SubAccountResponse>>(HttpMethod.Post, SubAccountUrls.SubAccount, requests);
        }

        /// <summary>
        /// This endpoint deletes a sub account on your integration.
        /// </summary>
        /// <param name="sunAccountCode"></param>
        /// <returns></returns>
        public async Task<BaseResponse> DeleteSubAccount(string sunAccountCode)
        {
            return await _baseClient.SendAsync<BaseResponse>(HttpMethod.Delete, SubAccountUrls.DeleteSubAccount.Replace("{subAccountCode}", sunAccountCode));
        }

        /// <summary>
        /// This endpoint returns the list of sub accounts that have been created on your integration.
        /// </summary>
        /// <returns></returns>
        public async Task<BaseResponse<SubAccountResponse[]>> GetSubAccounts()
        {
            return await _baseClient.SendAsync<BaseResponse<SubAccountResponse[]>>(HttpMethod.Get, SubAccountUrls.SubAccount);
        }

        /// <summary>
        /// This endpoint updates the details of an existing sub account.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<SubAccountResponse>> UpdateSubAccount(UpdateSubAccountRequest request)
        {
            return await _baseClient.SendAsync<BaseResponse<SubAccountResponse>>(HttpMethod.Put, SubAccountUrls.SubAccount, request);
        }
    }
}