using MonnifyDotnet.SDK.Models;

namespace MonnifyDotnet.SDK.Interfaces
{
    public interface IOtherService
    {
        Task<BaseResponse<BankResponse[]>> GetBanks();

        Task<BaseResponse<BankResponse[]>> GetBanksWithUSSDShortCode();
    }
}