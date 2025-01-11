using MonnifyDotnet.SDK.Interfaces;
using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;
using Newtonsoft.Json;

namespace MonnifyDotnet.SDK.Implementations
{
    public class OtherService : IOtherService
    {
        private readonly BaseService _baseService;

        public OtherService(BaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<BaseResponse<BankResponse[]>> GetBanks()
        {
            var client = await _baseService.GetAuthenticatedClientAsync();

            var response = await client.GetAsync(OtherUrls.GetBanks);
            
            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<BaseResponse<BankResponse[]>>(content);
        }

        public async Task<BaseResponse<BankResponse[]>> GetBanksWithUSSDShortCode()
        {
            var client = await _baseService.GetAuthenticatedClientAsync();

            var response = await client.GetAsync(OtherUrls.GetBanksWithUSSDShortCode);
            
            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<BaseResponse<BankResponse[]>>(content);
        }
    }
}