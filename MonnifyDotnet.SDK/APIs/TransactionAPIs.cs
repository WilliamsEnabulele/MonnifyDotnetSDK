using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;

namespace MonnifyDotnet.SDK.APIs
{
    public class TransactionAPIs
    {
        private readonly BaseClient _baseClient;

        public TransactionAPIs(BaseClient baseClient)
        {
            _baseClient = baseClient;
        }

        /// <summary>
        /// This endpoint authorizes charge on a card that uses 3DS Secure Authentication.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<Authorize3DSCardResponse>> Authorize3DSCard(Authorize3DSCard request)
        {
            return await _baseClient.SendAsync<BaseResponse<Authorize3DSCardResponse>>(HttpMethod.Post, TransactionUrls.Authorize3DS, request);
        }

        /// <summary>
        /// The endpoint authorizes an OTP to complete a charge on a card.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<AuthorizeOTPResponse>> AuthorizeOTP(AuthorizeOTP request)
        {
            return await _baseClient.SendAsync<BaseResponse<AuthorizeOTPResponse>>(HttpMethod.Post, TransactionUrls.AuthorizeOTP, request);
        }

        /// <summary>
        /// This endpoint allows you to initiate charge on a card.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<ChargeCardResponse>> ChargeCard(ChargeCard request)
        {
            return await _baseClient.SendAsync<BaseResponse<ChargeCardResponse>>(HttpMethod.Post, TransactionUrls.ChargeCard, request);
        }

        /// <summary>
        /// This endpoint returns a list of transactions carried out on your integration.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>

        public async Task<BaseResponse<GetAllTransactionsResponse>> GetAllTransactions(GetAllTransactions request)
        {
            var urlWithParams = $"{TransactionUrls.GetAllTransactions}?{Utilities.ToQueryString(request)}";
            return await _baseClient.SendAsync<BaseResponse<GetAllTransactionsResponse>>(HttpMethod.Get, urlWithParams);
        }

        /// <summary>
        /// This endpoint returns the status of a transaction (PENDING, OVERPAID, PARTIALLY_PAID, PAID, EXPIRED, FAILED, EXPIRED, CANCELLED)
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<TransactionStatusResponse>> GetTransactionStatus(string transactionReference)
        {
            var urlWithParams = $"{TransactionUrls.GetTransactionStatus}/{transactionReference}";
            return await _baseClient.SendAsync<BaseResponse<TransactionStatusResponse>>(HttpMethod.Get, urlWithParams);
        }

        /// <summary>
        /// This endpoint returns the status of a transaction using either the Monnify transaction reference or the merchant's payment reference as query parameters.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>

        public async Task<BaseResponse<TransactionStatusResponse>> GetTransactionStatusByReference(TransactionStatusByReference request)
        {
            var urlWithParams = $"{TransactionUrls.GetStatusByReference}?{Utilities.ToQueryString(request)}";
            return await _baseClient.SendAsync<BaseResponse<TransactionStatusResponse>>(HttpMethod.Get, urlWithParams);
        }

        /// <summary>
        /// This endpoint initialises the transaction that would be used for card payments and dynamic transfers.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<InitiateTransactionResponse>> InitiateTransaction(InitiatizeTransaction request)
        {
            return await _baseClient.SendAsync<BaseResponse<InitiateTransactionResponse>>(HttpMethod.Post, TransactionUrls.InitializeTransaction, request);
        }

        /// <summary>
        /// This endpoint generates a dynamic account number and its associated bank for one time payment.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<PayWithBankTransferResponse>> PayWithBankTransfer(PayWithBankTransfer request)
        {
            return await _baseClient.SendAsync<BaseResponse<PayWithBankTransferResponse>>(HttpMethod.Post, TransactionUrls.PayWithBankTransafer, request);
        }

        /// <summary>
        /// This endpoint allows you get short USSD codes for a transaction using the transactionReference of an initialized transaction and the bank code of the customer’s bank from the get banks endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse> PayWithUSSD(PayWithUSSD request)
        {
            return await _baseClient.SendAsync<BaseResponse>(HttpMethod.Post, TransactionUrls.PayWithUSSD, request);
        }
    }
}