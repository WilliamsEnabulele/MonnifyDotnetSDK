using MonnifyDotnet.SDK.Models;

namespace MonnifyDotnet.SDK.Interfaces
{
    public interface ICustomerReservedAccountService
    {
        Task<BaseResponse<ReservedAccountResponse>> CreateReservedAccount(ReservedAccountRequest request);

        Task<BaseResponse> CreateReservedAccountInvoice(CreateReservedAccountInvoiceRequest request);

        Task<BaseResponse<ReservedAccountResponse>> GetReservedAccountDetails(string accountReference);

        Task<BaseResponse> AddLinkedAccount(AddLinkedAccountRequest request, string accountReference);

        Task<BaseResponse> UpdateBVNForReserveAccount(UpdateBVNForReservedAccountRequest request, string accountReference);

        Task<BaseResponse<AllowedPaymentSourcesResponse>> UpdateAllowedPaymentSource(AllowedPaymentSourceRequest request, string accountReference);

        Task<BaseResponse<SplitConfigForReservedAccountResponse>> SplitConfigForReservedAccount(SplitConfigForReservedAccountRequest request, string accountReference);

        Task<BaseResponse> DealloacteReserveAccount(string accountReference);

        Task<BaseResponse<ReservedAccountTransactionsResponse>> GetReservedAccountTransactions(ReservedAccountTransactionsRequest request);

        Task<BaseResponse<UpdateKYCInfoResponse>> UpdateKYCInfo(UpdateKYCInfoRequest request, string accountReference);
    }
}