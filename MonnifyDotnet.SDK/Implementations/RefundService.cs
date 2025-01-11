using MonnifyDotnet.SDK.Interfaces;
using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace MonnifyDotnet.SDK.Implementations
{
    public class RefundService : IRefundService
    {
        private readonly BaseService _baseService;

        public RefundService(BaseService baseService)
        {
            _baseService = baseService;
        }

        /// <summary>
        /// This endpoint returns the list of all refunds available on your integration.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public async Task<BaseResponse<RefundsResponse>> GetAllRefunds(int page, int size)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.GetAsync($"{RefundUrls.GetAllRefunds}?page={page}&size{size}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<RefundsResponse>>(content);
        }

        /// <summary>
        /// This endpoint returns the status of an initiated refund.
        /// </summary>
        /// <param name="refundReference"></param>
        /// <returns></returns>
        public async Task<BaseResponse<RefundResponse>> GetRefundStatus(string refundReference)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.GetAsync(RefundUrls.GetRefundStatus.Replace("refundReference", refundReference));
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<RefundResponse>>(content);
        }

        /// <summary>
        /// This endpoint allows you to Initiate a refund.
        /// </summary>
        /// <param name="refundRequest"></param>
        /// <returns></returns>
        public async Task<BaseResponse<RefundResponse>> InitiateRefund(InitiateRefundRequest refundRequest)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.PostAsJsonAsync(RefundUrls.InitiateRefund, refundRequest);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<RefundResponse>>(content);
        }
    }
}