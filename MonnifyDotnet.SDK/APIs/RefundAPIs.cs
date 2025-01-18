using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;

namespace MonnifyDotnet.SDK.APIs
{
    public class RefundAPIs
    {
        private readonly BaseClient _baseClient;

        public RefundAPIs(BaseClient baseClient)
        {
            _baseClient = baseClient;
        }

        /// <summary>
        /// This endpoint returns the list of all refunds available on your integration.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public async Task<BaseResponse<RefundsResponse>> GetAllRefunds(int page, int size)
        {
            return await _baseClient.SendAsync<BaseResponse<RefundsResponse>>(HttpMethod.Get, $"{RefundUrls.GetAllRefunds}?page={page}&size{size}");
        }

        /// <summary>
        /// This endpoint returns the status of an initiated refund.
        /// </summary>
        /// <param name="refundReference"></param>
        /// <returns></returns>
        public async Task<BaseResponse<RefundResponse>> GetRefundStatus(string refundReference)
        {
            return await _baseClient.SendAsync<BaseResponse<RefundResponse>>(HttpMethod.Get, RefundUrls.GetRefundStatus.Replace("refundReference", refundReference));
        }

        /// <summary>
        /// This endpoint allows you to Initiate a refund.
        /// </summary>
        /// <param name="refundRequest"></param>
        /// <returns></returns>
        public async Task<BaseResponse<RefundResponse>> InitiateRefund(InitiateRefundRequest refundRequest)
        {
            return await _baseClient.SendAsync<BaseResponse<RefundResponse>>(HttpMethod.Post, RefundUrls.InitiateRefund, refundRequest);
        }
    }
}