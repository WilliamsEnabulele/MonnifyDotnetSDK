using MonnifyDotnet.SDK.Models;

namespace MonnifyDotnet.SDK.Interfaces
{
    public interface ILimitProfileService
    {
        Task<BaseResponse<LimitProfileResponse>> CreateLimitProfile(LimitProfileRequest request);

        Task<BaseResponse<GetLimitProfilesResponse>> GetLimitProfiles();

        Task<BaseResponse<LimitProfileResponse>> UpdateLimitProfile(LimitProfileRequest request, string limitProfileCode);

        Task<BaseResponse<ReserveAccountWithLimitResponse>> ReserveAccountWithLimit(ReserveAccountWithLimit request);

        Task<BaseResponse<ReserveAccountWithLimitResponse>> UpdateReserveAccountLimit(UpdateReserveAccountLimitRequest request);
    }
}