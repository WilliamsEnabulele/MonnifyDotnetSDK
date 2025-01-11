using MonnifyDotnet.SDK.Interfaces;
using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace MonnifyDotnet.SDK.Implementations
{
    public class DirectDebitService : IDirectDebitService
    {
        private readonly BaseService _baseService;

        public DirectDebitService(BaseService baseService)
        {
            _baseService = baseService;
        }

        /// <summary>
        /// This endpoint initiates the creation of a mandate
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<MandateResponse>> CreateMandate(CreateMandateRequest request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();

            var response = await client.PostAsJsonAsync(DirectDebitUrls.CreateMandate, request);
            
            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<BaseResponse<MandateResponse>>(content);
        }

        /// <summary>
        /// This endpoint debits an active mandate
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<DebitMandateResponse>> DebitMandate(DebitMandateRequest request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();

            var response = await client.PostAsJsonAsync(DirectDebitUrls.DebitMandate, request);
            
            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<BaseResponse<DebitMandateResponse>>(content);
        }

        /// <summary>
        /// This endpoint gets the status of a debited mandate
        /// </summary>
        /// <param name="paymentReference"></param>
        /// <returns></returns>
        public async Task<BaseResponse<DebitMandateResponse>> GetDebitStatus(string paymentReference)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();

            var response = await client.GetAsync($"{DirectDebitUrls.GetDebitStatus}?paymentReference={paymentReference}");
            
            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<BaseResponse<DebitMandateResponse>>(content);
        }

        /// <summary>
        /// This endpoint retrieves the details of a created mandate
        /// </summary>
        /// <param name="mandateReferences"></param>
        /// <returns></returns>
        public async Task<BaseResponse<GetMandateStatusResponse>> GetMandateStatus(string mandateReferences)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();

            var response = await client.GetAsync($"{DirectDebitUrls.GetMandateStatus}?mandateReferences={mandateReferences}");
            
            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<BaseResponse<GetMandateStatusResponse>>(content);
        }

        /// <summary>
        /// This endpoint cancels/deactivate a mandate
        /// </summary>
        /// <param name="mandateCode"></param>
        /// <returns></returns>
        public async Task<BaseResponse<MandateResponse>> UpdateMandate(string mandateCode)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();

            var response = await client.PostAsJsonAsync(DirectDebitUrls.UpdateMandate.Replace("{{mandateCode}}", mandateCode), new { });
            
            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<BaseResponse<MandateResponse>>(content);
        }
    }
}