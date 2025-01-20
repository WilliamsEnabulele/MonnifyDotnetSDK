using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;

namespace MonnifyDotnet.SDK.APIs
{
    public class OtherAPIs
    {
        private readonly BaseClient _baseClient;

        public OtherAPIs(BaseClient baseClient)
        {
            _baseClient = baseClient;
        }

        public async Task<BaseResponse<BankResponse[]>> GetBanks()
        {
            return await _baseClient.SendAsync<BaseResponse<BankResponse[]>>(HttpMethod.Get, OtherUrls.GetBanks);
        }

        public async Task<BaseResponse<BankResponse[]>> GetBanksWithUSSDShortCode()
        {
            return await _baseClient.SendAsync<BaseResponse<BankResponse[]>>(HttpMethod.Get, OtherUrls.GetBanksWithUSSDShortCode);
        }
    }
}