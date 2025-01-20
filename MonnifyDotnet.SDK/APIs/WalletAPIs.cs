using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;

namespace MonnifyDotnet.SDK.APIs
{
    public class WalletAPIs
    {
        private readonly BaseClient _baseClient;

        public WalletAPIs(BaseClient baseClient)
        {
            _baseClient = baseClient;
        }

        /// <summary>
        /// This endpoint creates wallets for merchants' customers
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<CreateWalletResponse>> CreateWallet(CreateWalletRequest request)
        {
            return await _baseClient.SendAsync<BaseResponse<CreateWalletResponse>>(HttpMethod.Post, WalletUrls.Create, request);
        }

        /// <summary>
        /// This endpoint returns the balance associated with a wallet
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public async Task<BaseResponse<WalletBalanceResponse>> GetWalletBalance(string accountNumber)
        {
            return await _baseClient.SendAsync<BaseResponse<WalletBalanceResponse>>(HttpMethod.Get, $"{WalletUrls.Balance}?accountNumber={accountNumber}");
        }

        /// <summary>
        /// This endpoint returns all the wallets created by a merchant
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<Wallet>> GetWallets(GetWalletsFilterRequest request)
        {
            return await _baseClient.SendAsync<BaseResponse<Wallet>>(HttpMethod.Get, $"{WalletUrls.Wallet}?{Utilities.ToQueryString(request)}");
        }

        /// <summary>
        /// This endpoint returns all the transactions performed by a wallet
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public async Task<BaseResponse<WalletTransactionsResponse>> GetWalletTransactions(string accountNumber)
        {
            return await _baseClient.SendAsync<BaseResponse<WalletTransactionsResponse>>(HttpMethod.Get, $"{WalletUrls.Transactions}?accountNumber={accountNumber}");
        }
    }
}