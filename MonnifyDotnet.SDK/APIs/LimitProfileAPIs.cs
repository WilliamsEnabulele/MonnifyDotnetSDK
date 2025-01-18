using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;

namespace MonnifyDotnet.SDK.APIs
{
    public class LimitProfileAPIs
    {
        private readonly BaseClient _baseClient;

        public LimitProfileAPIs(BaseClient baseClient)
        {
            _baseClient = baseClient;
        }

        /// <summary>
        /// This endpoint creates limit profiles on a customer's account.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<LimitProfileResponse>> CreateLimitProfile(LimitProfileRequest request)
        {
            return await _baseClient.SendAsync<BaseResponse<LimitProfileResponse>>(HttpMethod.Post, LimitProfileUrls.profile, request);
        }

        /// <summary>
        /// This endpoint returns the list of all Limit Profiles that have been created for your customers.
        /// </summary>
        /// <returns></returns>
        public async Task<BaseResponse<GetLimitProfilesResponse>> GetLimitProfiles()
        {
            return await _baseClient.SendAsync<BaseResponse<GetLimitProfilesResponse>>(HttpMethod.Get, LimitProfileUrls.profile);
        }

        /// <summary>
        /// This endpoint reserves an account for your customers with a transaction limit profile on it.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<BaseResponse<ReserveAccountWithLimitResponse>> ReserveAccountWithLimit(ReserveAccountWithLimit request)
        {
            return await _baseClient.SendAsync<BaseResponse<ReserveAccountWithLimitResponse>>(HttpMethod.Post, LimitProfileUrls.ReserveAccountWithLimit, request);
        }

        /// <summary>
        /// This endpoint updates the information on an existing Limit Profile.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="limitProfileCode"></param>
        /// <returns></returns>
        public async Task<BaseResponse<LimitProfileResponse>> UpdateLimitProfile(LimitProfileRequest request, string limitProfileCode)
        {
            return await _baseClient.SendAsync<BaseResponse<LimitProfileResponse>>(HttpMethod.Put, $"{LimitProfileUrls.profile}/{limitProfileCode}", request);
        }

        /// <summary>
        /// This endpoint updates the information on an existing Limit Profile for a Reserved Account.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<ReserveAccountWithLimitResponse>> UpdateReserveAccountLimit(UpdateReserveAccountLimitRequest request)
        {
            return await _baseClient.SendAsync<BaseResponse<ReserveAccountWithLimitResponse>>(HttpMethod.Put, LimitProfileUrls.ReserveAccountWithLimit, request);
        }
    }
}