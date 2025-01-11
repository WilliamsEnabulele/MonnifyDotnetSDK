using MonnifyDotnet.SDK.Interfaces;
using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace MonnifyDotnet.SDK.Implementations
{
    public class RecurringPaymentService : IRecurringPaymentService
    {
        private readonly BaseService _baseService;

        public RecurringPaymentService(BaseService baseService)
        {
            _baseService = baseService;
        }

        /// <summary>
        /// This endpoint allows you to charge an already tokenized card with it’s card token. **NOTE**: The customer email address used in the first successful charge should be stored along with the card token.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse> ChargeCardToken(ChargeCardTokenRequest request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.PostAsJsonAsync(RecurringPaymentUrls.ChargeCardToken, request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse>(content);
        }
    }
}