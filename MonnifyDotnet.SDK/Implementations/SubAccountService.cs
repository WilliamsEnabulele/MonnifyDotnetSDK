using MonnifyDotnet.SDK.Interfaces;
using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace MonnifyDotnet.SDK.Implementations
{
    public class SubAccountService : ISubAccountService
    {
        private readonly BaseService _baseService;

        public SubAccountService(BaseService baseService)
        {
            _baseService = baseService;
        }

        /// <summary>
        /// This endpoint allows you to create a sub account to enable the spliting of payments between different accounts.
        /// </summary>
        /// <param name="requests"></param>
        /// <returns></returns>
        public async Task<BaseResponse<SubAccountResponse>> CreateSubAccount(CreateSubAccountRequest[] requests)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();

            var response = await client.PostAsJsonAsync(SubAccountUrls.SubAccount, requests);
            
            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<BaseResponse<SubAccountResponse>>(content);
        }

        /// <summary>
        /// This endpoint deletes a sub account on your integration.
        /// </summary>
        /// <param name="sunAccountCode"></param>
        /// <returns></returns>
        public async Task<BaseResponse> DeleteSubAccount(string sunAccountCode)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();

            var response = await client.DeleteAsync(SubAccountUrls.DeleteSubAccount.Replace("{subAccountCode}", sunAccountCode));
            
            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<BaseResponse>(content);
        }

        /// <summary>
        /// This endpoint returns the list of sub accounts that have been created on your integration.
        /// </summary>
        /// <returns></returns>
        public async Task<BaseResponse<SubAccountResponse[]>> GetSubAccounts()
        {
            var client = await _baseService.GetAuthenticatedClientAsync();

            var response = await client.GetAsync(SubAccountUrls.SubAccount);
            
            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<BaseResponse<SubAccountResponse[]>>(content);
        }

        /// <summary>
        /// This endpoint updates the details of an existing sub account.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<SubAccountResponse>> UpdateSubAccount(UpdateSubAccountRequest request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();

            var response = await client.PutAsJsonAsync(SubAccountUrls.SubAccount, request);
            
            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<BaseResponse<SubAccountResponse>>(content);
        }
    }
}