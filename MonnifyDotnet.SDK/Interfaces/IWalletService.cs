using MonnifyDotnet.SDK.Models;

namespace MonnifyDotnet.SDK.Interfaces
{
    public interface IWalletService
    {
        Task<BaseResponse<CreateWalletResponse>> CreateWallet(CreateWalletRequest request);

        Task<BaseResponse<WalletBalanceResponse>> GetWalletBalance(string accountNumber);

        Task<BaseResponse<Wallet>> GetWallets(GetWalletsFilterRequest request);

        Task<BaseResponse<WalletTransactionsResponse>> GetWalletTransactions(string accountNumber);
    }
}