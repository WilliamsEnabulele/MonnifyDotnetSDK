using MonnifyDotnet.SDK.Interfaces;
using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace MonnifyDotnet.SDK.Implementations
{
    public class InvoiceService(BaseService baseService) : IInvoiceService
    {
        private readonly BaseService _baseService = baseService;

        /// <summary>
        /// This endpoint attaches a Reserved Account to an Invoice.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<AttachReserveAccountInvoiceResponse>> AttachReserveAccountInvoice(AttachReserveAccountInvoiceRequest request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.PostAsJsonAsync(InvoicesUrls.Invoice, request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<AttachReserveAccountInvoiceResponse>>(content);
        }

        /// <summary>
        /// This endpoint cancels an Invoice on your integration.
        /// </summary>
        /// <param name="invoiceReference"></param>
        /// <returns></returns>
        public async Task<BaseResponse<CancelAnInvoiceResponse>> CancelAnInvoice(string invoiceReference)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.DeleteAsync(InvoicesUrls.CancelAnInvoice.Replace("{invoiceReference}", invoiceReference));
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<CancelAnInvoiceResponse>>(content);
        }

        /// <summary>
        /// This endpoint creates invoice for payments on your integration.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<InvoiceResponse>> CreateInvoice(CreateInvoiceRequest request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.PostAsJsonAsync(InvoicesUrls.Invoice, request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<InvoiceResponse>>(content);
        }

        /// <summary>
        /// This endpoint returns the list of all the invoice available on your integration.
        /// </summary>
        /// <returns></returns>
        public async Task<BaseResponse<GetAllInvoicesResponse>> GetAllInvoices()
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.GetAsync(InvoicesUrls.GetAllInvoices);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<GetAllInvoicesResponse>>(content);
        }

        /// <summary>
        /// This endpoint returns details of an invoice on your integration.
        /// </summary>
        /// <param name="invoiceReference"></param>
        /// <returns></returns>
        public async Task<BaseResponse<InvoiceResponse>> ViewInvoiceDetails(string invoiceReference)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.GetAsync(InvoicesUrls.ViewInvoiceDetails.Replace("{invoiceReference}", invoiceReference));
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<InvoiceResponse>>(content);
        }
    }
}