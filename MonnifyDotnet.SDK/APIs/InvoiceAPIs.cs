using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;

namespace MonnifyDotnet.SDK.APIs
{
    public class InvoiceAPIs
    {
        private readonly BaseClient _baseClient;

        public InvoiceAPIs(BaseClient baseClient)
        {
            _baseClient = baseClient;
        }

        /// <summary>
        /// This endpoint attaches a Reserved Account to an Invoice.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<AttachReserveAccountInvoiceResponse>> AttachReserveAccountInvoice(AttachReserveAccountInvoiceRequest request)
        {
            return await _baseClient.SendAsync<BaseResponse<AttachReserveAccountInvoiceResponse>>(HttpMethod.Post, InvoicesUrls.Invoice, request);
        }

        /// <summary>
        /// This endpoint cancels an Invoice on your integration.
        /// </summary>
        /// <param name="invoiceReference"></param>
        /// <returns></returns>
        public async Task<BaseResponse<CancelAnInvoiceResponse>> CancelAnInvoice(string invoiceReference)
        {
            return await _baseClient.SendAsync<BaseResponse<CancelAnInvoiceResponse>>(HttpMethod.Delete, InvoicesUrls.CancelAnInvoice.Replace("{invoiceReference}", invoiceReference));
        }

        /// <summary>
        /// This endpoint creates invoice for payments on your integration.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<InvoiceResponse>> CreateInvoice(CreateInvoiceRequest request)
        {
            return await _baseClient.SendAsync<BaseResponse<InvoiceResponse>>(HttpMethod.Post, InvoicesUrls.Invoice, request);
        }

        /// <summary>
        /// This endpoint returns the list of all the invoice available on your integration.
        /// </summary>
        /// <returns></returns>
        public async Task<BaseResponse<GetAllInvoicesResponse>> GetAllInvoices()
        {
            return await _baseClient.SendAsync<BaseResponse<GetAllInvoicesResponse>>(HttpMethod.Get, InvoicesUrls.GetAllInvoices);
        }

        /// <summary>
        /// This endpoint returns details of an invoice on your integration.
        /// </summary>
        /// <param name="invoiceReference"></param>
        /// <returns></returns>
        public async Task<BaseResponse<InvoiceResponse>> ViewInvoiceDetails(string invoiceReference)
        {
            return await _baseClient.SendAsync<BaseResponse<InvoiceResponse>>(HttpMethod.Get, InvoicesUrls.ViewInvoiceDetails.Replace("{invoiceReference}", invoiceReference));
        }
    }
}