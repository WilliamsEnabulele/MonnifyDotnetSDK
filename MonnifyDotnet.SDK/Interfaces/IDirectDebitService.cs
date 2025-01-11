using MonnifyDotnet.SDK.Models;

namespace MonnifyDotnet.SDK.Interfaces
{
    public interface IDirectDebitService
    {
        Task<BaseResponse<MandateResponse>> CreateMandate(CreateMandateRequest request);

        Task<BaseResponse<GetMandateStatusResponse>> GetMandateStatus(string mandateReferences);

        Task<BaseResponse<DebitMandateResponse>> DebitMandate(DebitMandateRequest request);

        Task<BaseResponse<DebitMandateResponse>> GetDebitStatus(string paymentReference);

        Task<BaseResponse<MandateResponse>> UpdateMandate(string mandateCode);
    }
}