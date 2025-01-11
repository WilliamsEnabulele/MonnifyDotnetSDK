using Newtonsoft.Json;

namespace MonnifyDotnet.SDK.Models
{

    public class ReservedAccountRequest
    {
        [JsonProperty("accountReference")]
        public required string AccountReference { get; set; }
        [JsonProperty("accountName")]
        public required string AccountName { get; set; }
        [JsonProperty("currencyCode")]
        public required string CurrencyCode { get; set; }
        [JsonProperty("contractCode")]
        public required string ContractCode { get; set; }
        [JsonProperty("customerEmail")]
        public required string CustomerEmail { get; set; }
        [JsonProperty("customerName")]
        public required string CustomerName { get; set; }
        [JsonProperty("bvn")]
        public string? BVN { get; set; }
        [JsonProperty("getAllAvailableBanks")]
        public bool GetAllAvailableBanks { get; set; }
    }

    public class ReservedAccountResponse
    {
        [JsonProperty("contractCode")]
        public required string ContractCode { get; set; }
        [JsonProperty("accountReference")]
        public required string AccountReference { get; set; }
        [JsonProperty("accountName")]
        public required string AccountName { get; set; }
        [JsonProperty("currencyCode")]
        public required string CurrencyCode { get; set; }
        [JsonProperty("customerEmail")]
        public required string CustomerEmail { get; set; }
        [JsonProperty("customerName")]
        public required string CustomerName { get; set; }
        [JsonProperty("accounts")]
        public Account[]? Accounts { get; set; }
        [JsonProperty("collectionChannel")]
        public required string CollectionChannel { get; set; }
        [JsonProperty("reservationReference")]
        public required string ReservationReference { get; set; }
        [JsonProperty("reservedAccountType")]
        public required string ReservedAccountType { get; set; }
        [JsonProperty("status")]
        public required string Status { get; set; }
        [JsonProperty("createdOn")]
        public required string CreatedOn { get; set; }
        [JsonProperty("incomeSplitConfig")]
        public object[]? IncomeSplitConfig { get; set; }
        [JsonProperty("bvn")]
        public required string BVN { get; set; }
        [JsonProperty("restrictPaymentSource")]
        public bool RestrictPaymentSource { get; set; }
    }

    public class Account
    {
        [JsonProperty("bankCode")]
        public required string BankCode { get; set; }
        [JsonProperty("bankName")]
        public required string BankName { get; set; }
        [JsonProperty("accountNumber")]
        public required string AccountNumber { get; set; }
        [JsonProperty("accountName")]
        public required string AccountName { get; set; }
    }


    public class CreateReservedAccountInvoiceRequest
    {
        [JsonProperty("contractCode")]
        public required string ContractCode { get; set; }
        [JsonProperty("accountName")]
        public required string AccountName { get; set; }
        [JsonProperty("currencyCode")]
        public required string CurrencyCode { get; set; }
        [JsonProperty("accountReference")]
        public required string AccountReference { get; set; }
        [JsonProperty("customerEmail")]
        public required string CustomerEmail { get; set; }
        [JsonProperty("customerName")]
        public string? CustomerName { get; set; }
        [JsonProperty("reservedAccountType")]
        public string? ReservedAccountType { get; set; }
        [JsonProperty("bvn")]
        public string? BVN { get; set; }
        [JsonProperty("nin")]
        public string? NIN { get; set; }
    }

    public class GetReservedAccountResponse
    {
        [JsonProperty("contractCode")]
        public required string ContractCode { get; set; }
        [JsonProperty("accountReference")]
        public required string AccountReference { get; set; }
        [JsonProperty("accountName")]
        public required string AccountName { get; set; }
        [JsonProperty("currencyCode")]
        public required string CurrencyCode { get; set; }
        [JsonProperty("customerEmail")]
        public required string CustomerEmail { get; set; }
        [JsonProperty("customerName")]
        public required string CustomerName { get; set; }
        [JsonProperty("accounts")]
        public required Account[] Accounts { get; set; }
        [JsonProperty("collectionChannel")]
        public required string CollectionChannel { get; set; }
        [JsonProperty("reservationReference")]
        public required string ReservationReference { get; set; }
        [JsonProperty("reservedAccountType")]
        public required string ReservedAccountType { get; set; }
        [JsonProperty("status")]
        public required string Status { get; set; }
        [JsonProperty("createdOn")]
        public required string CreatedOn { get; set; }
        [JsonProperty("contract")]
        public required Contract Contract { get; set; }
        [JsonProperty("transactionCount")]
        public int TransactionCount { get; set; }
        [JsonProperty("bvn")]
        public required string BVN { get; set; }
        [JsonProperty("restrictPaymentSource")]
        public bool RestrictPaymentSource { get; set; }
    }

    public class Contract
    {
        [JsonProperty("name")]
        public required string Name { get; set; }
        [JsonProperty("code")]
        public required string Code { get; set; }
        [JsonProperty("description")]
        public object? Description { get; set; }
    }


    public class AddLinkedAccountRequest
    {
        [JsonProperty("getAllAvailableBanks")]
        public bool GetAllAvailableBanks { get; set; }
        [JsonProperty("preferredBanks")]
        public string[] PreferredBanks { get; set; } = [];
    }


    public class UpdateBVNForReservedAccountRequest
    {
        [JsonProperty("bvn")]
        public required string BVN { get; set; }
    }


    public class AllowedPaymentSourceRequest
    {
        [JsonProperty("restrictPaymentSource")]
        public bool RestrictPaymentSource { get; set; }
        [JsonProperty("allowedPaymentSources")]
        public required AllowedPaymentSources AllowedPaymentSources { get; set; }
    }

    public class AllowedPaymentSources
    {
        [JsonProperty("bvns")]
        public string[] BVNs { get; set; } = [];
        [JsonProperty("bankAccounts")]
        public BankAccount[] BankAccounts { get; set; } = [];
        [JsonProperty("accountNames")]
        public string[] AccountNames { get; set; } = [];
    }


    public class AllowedPaymentSourcesResponse
    {
        [JsonProperty("restrictPaymentSource")]
        public bool RestrictPaymentSource { get; set; }
        [JsonProperty("allowedPaymentSources")]
        public AllowedPaymentSources? AllowedPaymentSources { get; set; }
    }

    public class BankAccount
    {
        [JsonProperty("accountNumber")]
        public required string AccountNumber { get; set; }
        [JsonProperty("bankCode")]
        public required string BankCode { get; set; }
    }


    public class SplitConfigForReservedAccountRequest
    {
        [JsonProperty("configDetails")]
        public ConfigDetail[] ConfigDetails { get; set; } = [];
    }

    public class ConfigDetail
    {
        [JsonProperty("subAccountCode")]
        public string? SubAccountCode { get; set; }
        [JsonProperty("feePercentage")]
        public float FeePercentage { get; set; }
        [JsonProperty("splitPercentage")]
        public int SplitPercentage { get; set; }
        [JsonProperty("feeBearer")]
        public bool FeeBearer { get; set; }
        [JsonProperty("reservedAccountConfigCode")]
        public string? ReservedAccountConfigCode { get; set; }
    }


    public class SplitConfigForReservedAccountResponse
    {
        [JsonProperty("code")]
        public required string Code { get; set; }
        [JsonProperty("reservedAccountCode")]
        public required string ReservedAccountCode { get; set; }
        [JsonProperty("feeBearer")]
        public required string FeeBearer { get; set; }
        [JsonProperty("configDetails")]
        public ConfigDetail[] ConfigDetails { get; set; } = [];
    }

    public class ReservedAccountTransactionsRequest
    {
        [JsonProperty("accountReference")]
        public string? AccountReference { get; set; }
        [JsonProperty("page")]
        public int Page { get; set; }
        [JsonProperty("size")]
        public int Size { get; set; }
    }


    public class ReservedAccountTransactionsResponse
    {
        [JsonProperty("content")]
        public ReservedAccountTransaction[] Content { get; set; } = [];
    }


    public class ReservedAccountTransaction
    {
        [JsonProperty("customerDTO")]
        public required Customerdto CustomerDTO { get; set; }
        [JsonProperty("providerAmount")]
        public float ProviderAmount { get; set; }
        [JsonProperty("paymentMethod")]
        public required string PaymentMethod { get; set; }
        [JsonProperty("createdOn")]
        public DateTime CreatedOn { get; set; }
        [JsonProperty("amount")]
        public float Amount { get; set; }
        [JsonProperty("flagged")]
        public bool Flagged { get; set; }
        [JsonProperty("providerCode")]
        public required string ProviderCode { get; set; }
        [JsonProperty("fee")]
        public float Fee { get; set; }
        [JsonProperty("currencyCode")]
        public required string CurrencyCode { get; set; }
        [JsonProperty("completedOn")]
        public DateTime CompletedOn { get; set; }
        [JsonProperty("paymentDescription")]
        public required string PaymentDescription { get; set; }
        [JsonProperty("paymentStatus")]
        public required string PaymentStatus { get; set; }
        [JsonProperty("transactionReference")]
        public required string TransactionReference { get; set; }
        [JsonProperty("paymentReference")]
        public required string PaymentReference { get; set; }
        [JsonProperty("merchantCode")]
        public required string MerchantCode { get; set; }
        [JsonProperty("merchantName")]
        public required string MerchantName { get; set; }
        [JsonProperty("settleInstantly")]
        public bool SettleInstantly { get; set; }
        [JsonProperty("payableAmount")]
        public float PayableAmount { get; set; }
        [JsonProperty("amountPaid")]
        public float AmountPaid { get; set; }
        [JsonProperty("completed")]
        public bool Completed { get; set; }
    }

    public class UpdateKYCInfoRequest
    {
        [JsonProperty("bvn")]
        public string? BVN { get; set; }
        [JsonProperty("nin")]
        public string? NIN { get; set; }
    }


    public class UpdateKYCInfoResponse
    {
        [JsonProperty("accountReference")]
        public required string AccountReference { get; set; }
        [JsonProperty("accountName")]
        public required string AccountName { get; set; }
        [JsonProperty("customerEmail")]
        public required string CustomerEmail { get; set; }
        [JsonProperty("customerName")]
        public required string CustomerName { get; set; }
        [JsonProperty("bvn")]
        public required string BVN { get; set; }
    }

}