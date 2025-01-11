using MonnifyDotnet.SDK.Interfaces;
using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;
using Newtonsoft.Json;
using System.Net.Http.Json;
using TransactionStatus = MonnifyDotnet.SDK.Models.TransactionStatus;

namespace MonnifyDotnet.SDK.Implementations
{
    public class TransactionService : ITransactionService
    {
        private readonly BaseService _baseService;

        public TransactionService(BaseService baseService)
        {
            _baseService = baseService;
        }

        /// <summary>
        /// This endpoint authorizes charge on a card that uses 3DS Secure Authentication.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<Authorize3DSCardResponse>> Authorize3DSCard(Authorize3DSCard request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();

            var response = await client.PostAsJsonAsync(TransactionUrls.Authorize3DS, request);

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<BaseResponse<Authorize3DSCardResponse>>(content);
        }

        /// <summary>
        /// The endpoint authorizes an OTP to complete a charge on a card.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<AuthorizeOTPResponse>> AuthorizeOTP(AuthorizeOTP request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();

            var response = await client.PostAsJsonAsync(TransactionUrls.AuthorizeOTP, request);

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<BaseResponse<AuthorizeOTPResponse>>(content);
        }

        /// <summary>
        /// This endpoint allows you to initiate charge on a card.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<ChargeCardResponse>> ChargeCard(ChargeCard request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.PostAsJsonAsync(TransactionUrls.ChargeCard, request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<ChargeCardResponse>>(content);
        }

        /// <summary>
        /// This endpoint returns a list of transactions carried out on your integration.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>

        public async Task<BaseResponse<GetAllTransactionsResponse>> GetAllTransactions(GetAllTransactions request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var urlWithParams = $"{TransactionUrls.GetAllTransactions}?{Utilities.ToQueryString(request)}";
            var response = await client.GetAsync(urlWithParams);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<GetAllTransactionsResponse>>(content);
        }

        /// <summary>
        /// This endpoint returns the status of a transaction (PENDING, OVERPAID, PARTIALLY_PAID, PAID, EXPIRED, FAILED, EXPIRED, CANCELLED)
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<TransactionStatusResponse>> GetTransactionStatus(TransactionStatus request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var urlWithParams = $"{TransactionUrls.GetTransactionStatus}/{request.TransactionReference}";
            var response = await client.GetAsync(urlWithParams);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<TransactionStatusResponse>>(content);
        }

        /// <summary>
        /// This endpoint returns the status of a transaction using either the Monnify transaction reference or the merchant's payment reference as query parameters.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>

        public async Task<BaseResponse<TransactionStatusResponse>> GetTransactionStatusByReference(TransactionStatusByReference request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var urlWithParams = $"{TransactionUrls.GetStatusByReference}?{Utilities.ToQueryString(request)}";
            var response = await client.GetAsync(urlWithParams);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<TransactionStatusResponse>>(content);
        }

        /// <summary>
        /// This endpoint initialises the transaction that would be used for card payments and dynamic transfers.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<InitiateTransactionResponse>> InitiateTransaction(InitiatizeTransaction request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();

            var response = await client.PostAsJsonAsync(TransactionUrls.InitializeTransaction, request);

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<BaseResponse<InitiateTransactionResponse>>(content);
        }

        /// <summary>
        /// This endpoint generates a dynamic account number and its associated bank for one time payment.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<PayWithBankTransferResponse>> PayWithBankTransfer(PayWithBankTransfer request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();

            var response = await client.PostAsJsonAsync(TransactionUrls.PayWithBankTransafer, request);

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<BaseResponse<PayWithBankTransferResponse>>(content);
        }

        /// <summary>
        /// This endpoint allows you get short USSD codes for a transaction using the transactionReference of an initialized transaction and the bank code of the customer’s bank from the get banks endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse> PayWithUSSD(PayWithUSSD request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();

            var response = await client.PostAsJsonAsync(TransactionUrls.PayWithUSSD, request);

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<BaseResponse>(content);
        }
    }
}