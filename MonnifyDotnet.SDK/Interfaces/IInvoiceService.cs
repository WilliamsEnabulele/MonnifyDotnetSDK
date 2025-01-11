using MonnifyDotnet.SDK.Models;

namespace MonnifyDotnet.SDK.Interfaces
{
    public interface IInvoiceService
    {
        Task<BaseResponse<InvoiceResponse>> CreateInvoice(CreateInvoiceRequest request);

        Task<BaseResponse<InvoiceResponse>> ViewInvoiceDetails(string invoiceReference);

        Task<BaseResponse<GetAllInvoicesResponse>> GetAllInvoices();

        Task<BaseResponse<CancelAnInvoiceResponse>> CancelAnInvoice(string invoiceReference);

        Task<BaseResponse<AttachReserveAccountInvoiceResponse>> AttachReserveAccountInvoice(AttachReserveAccountInvoiceRequest request);
    }
}