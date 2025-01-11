using MonnifyDotnet.SDK.Interfaces;
using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace MonnifyDotnet.SDK.Implementations
{
    public class LimitProfileService : ILimitProfileService
    {
        private readonly BaseService _baseService;

        public LimitProfileService(BaseService baseService)
        {
            _baseService = baseService;
        }

        /// <summary>
        /// This endpoint creates limit profiles on a customer's account.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<LimitProfileResponse>> CreateLimitProfile(LimitProfileRequest request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();

            var response = await client.PostAsJsonAsync(LimitProfileUrls.profile, request);
            
            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<BaseResponse<LimitProfileResponse>>(content);
        }

        /// <summary>
        /// This endpoint returns the list of all Limit Profiles that have been created for your customers.
        /// </summary>
        /// <returns></returns>
        public async Task<BaseResponse<GetLimitProfilesResponse>> GetLimitProfiles()
        {
            var client = await _baseService.GetAuthenticatedClientAsync();

            var response = await client.GetAsync(LimitProfileUrls.profile);
            
            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<BaseResponse<GetLimitProfilesResponse>>(content);
        }

        /// <summary>
        /// This endpoint reserves an account for your customers with a transaction limit profile on it.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<BaseResponse<ReserveAccountWithLimitResponse>> ReserveAccountWithLimit(ReserveAccountWithLimit request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();

            var response = await client.PostAsJsonAsync(LimitProfileUrls.ReserveAccountWithLimit, request);
            
            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<BaseResponse<ReserveAccountWithLimitResponse>>(content);
        }

        /// <summary>
        /// This endpoint updates the information on an existing Limit Profile.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="limitProfileCode"></param>
        /// <returns></returns>
        public async Task<BaseResponse<LimitProfileResponse>> UpdateLimitProfile(LimitProfileRequest request, string limitProfileCode)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();

            var response = await client.PutAsJsonAsync($"{LimitProfileUrls.profile}/{limitProfileCode}", request);
            
            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<BaseResponse<LimitProfileResponse>>(content);
        }

        /// <summary>
        /// This endpoint updates the information on an existing Limit Profile for a Reserved Account.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<ReserveAccountWithLimitResponse>> UpdateReserveAccountLimit(UpdateReserveAccountLimitRequest request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();

            var response = await client.PutAsJsonAsync(LimitProfileUrls.ReserveAccountWithLimit, request);
            
            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<BaseResponse<ReserveAccountWithLimitResponse>>(content);
        }
    }
}