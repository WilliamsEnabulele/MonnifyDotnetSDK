using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;

namespace MonnifyDotnet.SDK.APIs
{
    public class DirectDebitAPIs
    {
        private readonly BaseClient _baseClient;

        public DirectDebitAPIs(BaseClient baseClient)
        {
            _baseClient = baseClient;
        }

        /// <summary>
        /// This endpoint initiates the creation of a mandate
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<MandateResponse>> CreateMandate(CreateMandateRequest request)
        {
            return await _baseClient.SendAsync<BaseResponse<MandateResponse>>(HttpMethod.Post, DirectDebitUrls.CreateMandate, request);
        }

        /// <summary>
        /// This endpoint debits an active mandate
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<DebitMandateResponse>> DebitMandate(DebitMandateRequest request)
        {
            return await _baseClient.SendAsync<BaseResponse<DebitMandateResponse>>(HttpMethod.Post, DirectDebitUrls.DebitMandate, request);
        }

        /// <summary>
        /// This endpoint gets the status of a debited mandate
        /// </summary>
        /// <param name="paymentReference"></param>
        /// <returns></returns>
        public async Task<BaseResponse<DebitMandateResponse>> GetDebitStatus(string paymentReference)
        {
            return await _baseClient.SendAsync<BaseResponse<DebitMandateResponse>>(HttpMethod.Get, $"{DirectDebitUrls.GetDebitStatus}?paymentReference={paymentReference}");
        }

        /// <summary>
        /// This endpoint retrieves the details of a created mandate
        /// </summary>
        /// <param name="mandateReferences"></param>
        /// <returns></returns>
        public async Task<BaseResponse<GetMandateStatusResponse>> GetMandateStatus(string mandateReferences)
        {
            return await _baseClient.SendAsync<BaseResponse<GetMandateStatusResponse>>(HttpMethod.Get, $"{DirectDebitUrls.GetMandateStatus}?mandateReferences={mandateReferences}");
        }

        /// <summary>
        /// This endpoint cancels/deactivate a mandate
        /// </summary>
        /// <param name="mandateCode"></param>
        /// <returns></returns>
        public async Task<BaseResponse<MandateResponse>> UpdateMandate(string mandateCode)
        {
            return await _baseClient.SendAsync<BaseResponse<MandateResponse>>(HttpMethod.Post, DirectDebitUrls.UpdateMandate.Replace("{{mandateCode}}", mandateCode), new { });
        }
    }
}