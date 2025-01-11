using MonnifyDotnet.SDK.Interfaces;
using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace MonnifyDotnet.SDK.Implementations
{
    public class WalletService : IWalletService
    {
        private readonly BaseService _baseService;

        public WalletService(BaseService baseService)
        {
            _baseService = baseService;
        }

        /// <summary>
        /// This endpoint creates wallets for merchants' customers
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<CreateWalletResponse>> CreateWallet(CreateWalletRequest request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.PostAsJsonAsync(WalletUrls.Create, request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<CreateWalletResponse>>(content);
        }

        /// <summary>
        /// This endpoint returns the balance associated with a wallet
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public async Task<BaseResponse<WalletBalanceResponse>> GetWalletBalance(string accountNumber)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.GetAsync($"{WalletUrls.Balance}?accountNumber={accountNumber}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<WalletBalanceResponse>>(content);
        }

        /// <summary>
        /// This endpoint returns all the wallets created by a merchant
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<Wallet>> GetWallets(GetWalletsFilterRequest request)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var urlWithParams = $"{WalletUrls.Wallet}?{Utilities.ToQueryString(request)}";
            var response = await client.GetAsync(urlWithParams);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<Wallet>>(content);
        }

        /// <summary>
        /// This endpoint returns all the transactions performed by a wallet
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public async Task<BaseResponse<WalletTransactionsResponse>> GetWalletTransactions(string accountNumber)
        {
            var client = await _baseService.GetAuthenticatedClientAsync();
            var response = await client.GetAsync($"{WalletUrls.Transactions}?accountNumber={accountNumber}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BaseResponse<WalletTransactionsResponse>>(content);
        }
    }
}