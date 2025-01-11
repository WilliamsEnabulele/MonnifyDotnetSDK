using Newtonsoft.Json;

namespace MonnifyDotnet.SDK.Models
{

    public class CreateWalletRequest
    {
        [JsonProperty("walletReference")]
        public string? WalletReference { get; set; }

        [JsonProperty("walletName")]
        public string? WalletName { get; set; }

        [JsonProperty("customerName")]
        public string? CustomerName { get; set; }

        [JsonProperty("bvnDetails")]
        public BVNDetails? BVNDetails { get; set; }

        [JsonProperty("customerEmail")]
        public string? CustomerEmail { get; set; }
    }

    public class BVNDetails
    {
        [JsonProperty("bvn")]
        public string? BVN { get; set; }

        [JsonProperty("bvnDateOfBirth")]
        public string? BVNDateOfBirth { get; set; }
    }

    public class CreateWalletResponse
    {
        [JsonProperty("walletName")]
        public string? WalletName { get; set; }

        [JsonProperty("walletReference")]
        public string? WalletReference { get; set; }

        [JsonProperty("customerName")]
        public string? CustomerName { get; set; }

        [JsonProperty("customerEmail")]
        public string? CustomerEmail { get; set; }

        [JsonProperty("feeBearer")]
        public string? FeeBearer { get; set; }

        [JsonProperty("bvnDetails")]
        public BVNDetails? BVNDetails { get; set; }

        [JsonProperty("accountNumber")]
        public string? AccountNumber { get; set; }

        [JsonProperty("accountName")]
        public string? AccountName { get; set; }
    }

    public class WalletBalanceResponse
    {
        [JsonProperty("availableBalance")]
        public float AvailableBalance { get; set; }

        [JsonProperty("ledgerBalance")]
        public float LedgerBalance { get; set; }
    }

    public class GetWalletsFilterRequest
    {
        [JsonProperty("customerEmail")]
        public string? CustomerEmail { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("pageNo")]
        public int PageNo { get; set; }
    }

    public class GetWalletsResponse
    {
        [JsonProperty("content")]
        public required Wallet[] Content { get; set; }
    }

    public class Wallet
    {
        [JsonProperty("walletName")]
        public string? WalletName { get; set; }

        [JsonProperty("walletReference")]
        public string? WalletReference { get; set; }

        [JsonProperty("customerName")]
        public string? CustomerName { get; set; }

        [JsonProperty("customerEmail")]
        public string? CustomerEmail { get; set; }

        [JsonProperty("feeBearer")]
        public string? FeeBearer { get; set; }

        [JsonProperty("bvnDetails")]
        public BVNDetails? BVNDetails { get; set; }

        [JsonProperty("accountNumber")]
        public string? AccountNumber { get; set; }

        [JsonProperty("accountName")]
        public string? AccountName { get; set; }

        [JsonProperty("topUpAccountDetails")]
        public Topupaccountdetails? TopUpAccountDetails { get; set; }
    }

    public class Topupaccountdetails
    {
        [JsonProperty("accountNumber")]
        public string? AccountNumber { get; set; }

        [JsonProperty("accountName")]
        public string? AccountName { get; set; }

        [JsonProperty("bankCode")]
        public string? BankCode { get; set; }

        [JsonProperty("bankName")]
        public string? BankName { get; set; }
    }

    public class WalletTransactionsResponse
    {
        [JsonProperty("content")]
        public required WalletTransaction[] Content { get; set; }
    }

    public class WalletTransaction
    {
        [JsonProperty("walletTransactionReference")]
        public string? WalletTransactionReference { get; set; }

        [JsonProperty("monnifyTransactionReference")]
        public string? MonnifyTransactionReference { get; set; }

        [JsonProperty("availableBalanceBefore")]
        public object? AvailableBalanceBefore { get; set; }

        [JsonProperty("availableBalanceAfter")]
        public object? AvailableBalanceAfter { get; set; }

        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("transactionDate")]
        public DateTime TransactionDate { get; set; }

        [JsonProperty("transactionType")]
        public string? TransactionType { get; set; }

        [JsonProperty("message")]
        public object? Message { get; set; }

        [JsonProperty("narration")]
        public object? Narration { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }
    }
}