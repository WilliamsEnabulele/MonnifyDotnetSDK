using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;

namespace MonnifyDotnet.SDK.APIs
{
    public class RecurringPaymentAPIs
    {
        private readonly BaseClient _baseClient;

        public RecurringPaymentAPIs(BaseClient baseClient)
        {
            _baseClient = baseClient;
        }

        /// <summary>
        /// This endpoint allows you to charge an already tokenized card with it’s card token. **NOTE**: The customer email address used in the first successful charge should be stored along with the card token.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse> ChargeCardToken(ChargeCardTokenRequest request)
        {
            return await _baseClient.SendAsync<BaseResponse>(HttpMethod.Post, RecurringPaymentUrls.ChargeCardToken, request);
        }
    }
}