using Newtonsoft.Json;

namespace MonnifyDotnet.SDK.Models
{
    public class ReservedAccountRequest
    {
        [JsonProperty("accountReference")]
        public string AccountReference { get; set; }

        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("contractCode")]
        public string ContractCode { get; set; }

        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("bvn")]
        public string? BVN { get; set; }

        [JsonProperty("getAllAvailableBanks")]
        public bool GetAllAvailableBanks { get; set; }

        public ReservedAccountRequest(
            string accountReference,
            string accountName,
            string currencyCode,
            string contractCode,
            string customerEmail,
            string customerName)
        {
            AccountReference = accountReference ?? throw new ArgumentNullException(nameof(accountReference));
            AccountName = accountName ?? throw new ArgumentNullException(nameof(accountName));
            CurrencyCode = currencyCode ?? throw new ArgumentNullException(nameof(currencyCode));
            ContractCode = contractCode ?? throw new ArgumentNullException(nameof(contractCode));
            CustomerEmail = customerEmail ?? throw new ArgumentNullException(nameof(customerEmail));
            CustomerName = customerName ?? throw new ArgumentNullException(nameof(customerName));
        }
    }

    public class ReservedAccountResponse
    {
        [JsonProperty("contractCode")]
        public string? ContractCode { get; set; }

        [JsonProperty("accountReference")]
        public string? AccountReference { get; set; }

        [JsonProperty("accountName")]
        public string? AccountName { get; set; }

        [JsonProperty("currencyCode")]
        public string? CurrencyCode { get; set; }

        [JsonProperty("customerEmail")]
        public string? CustomerEmail { get; set; }

        [JsonProperty("customerName")]
        public string? CustomerName { get; set; }

        [JsonProperty("accounts")]
        public Account[]? Accounts { get; set; }

        [JsonProperty("collectionChannel")]
        public string? CollectionChannel { get; set; }

        [JsonProperty("reservationReference")]
        public string? ReservationReference { get; set; }

        [JsonProperty("reservedAccountType")]
        public string? ReservedAccountType { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("createdOn")]
        public string? CreatedOn { get; set; }

        [JsonProperty("incomeSplitConfig")]
        public object[]? IncomeSplitConfig { get; set; }

        [JsonProperty("bvn")]
        public string? BVN { get; set; }

        [JsonProperty("restrictPaymentSource")]
        public bool? RestrictPaymentSource { get; set; }
    }

    public class Account
    {
        [JsonProperty("bankCode")]
        public string? BankCode { get; set; }
        [JsonProperty("bankName")]
        public string? BankName { get; set; }
        [JsonProperty("accountNumber")]
        public string? AccountNumber { get; set; }
        [JsonProperty("accountName")]
        public string? AccountName { get; set; }
    }

    public class CreateReservedAccountInvoiceRequest
    {
        [JsonProperty("contractCode")]
        public string ContractCode { get; set; }

        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("accountReference")]
        public string AccountReference { get; set; }

        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }

        [JsonProperty("customerName")]
        public string? CustomerName { get; set; }

        [JsonProperty("reservedAccountType")]
        public string? ReservedAccountType { get; set; }

        [JsonProperty("bvn")]
        public string? BVN { get; set; }

        [JsonProperty("nin")]
        public string? NIN { get; set; }

        public CreateReservedAccountInvoiceRequest(
            string contractCode,
            string accountName,
            string currencyCode,
            string accountReference,
            string customerEmail)
        {
            ContractCode = contractCode ?? throw new ArgumentNullException(nameof(contractCode));
            AccountName = accountName ?? throw new ArgumentNullException(nameof(accountName));
            CurrencyCode = currencyCode ?? throw new ArgumentNullException(nameof(currencyCode));
            AccountReference = accountReference ?? throw new ArgumentNullException(nameof(accountReference));
            CustomerEmail = customerEmail ?? throw new ArgumentNullException(nameof(customerEmail));
        }
    }


    public class GetReservedAccountResponse
    {
        [JsonProperty("contractCode")]
        public string? ContractCode { get; set; }

        [JsonProperty("accountReference")]
        public string? AccountReference { get; set; }

        [JsonProperty("accountName")]
        public string? AccountName { get; set; }

        [JsonProperty("currencyCode")]
        public string? CurrencyCode { get; set; }

        [JsonProperty("customerEmail")]
        public string? CustomerEmail { get; set; }

        [JsonProperty("customerName")]
        public string? CustomerName { get; set; }

        [JsonProperty("accounts")]
        public Account[]? Accounts { get; set; }

        [JsonProperty("collectionChannel")]
        public string? CollectionChannel { get; set; }

        [JsonProperty("reservationReference")]
        public string? ReservationReference { get; set; }

        [JsonProperty("reservedAccountType")]
        public string? ReservedAccountType { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("createdOn")]
        public string? CreatedOn { get; set; }

        [JsonProperty("contract")]
        public Contract? Contract { get; set; }

        [JsonProperty("transactionCount")]
        public int? TransactionCount { get; set; }

        [JsonProperty("bvn")]
        public string? BVN { get; set; }

        [JsonProperty("restrictPaymentSource")]
        public bool? RestrictPaymentSource { get; set; }
    }

    public class Contract
    {
        [JsonProperty("name")]
        public string? Name { get; set; }
        [JsonProperty("code")]
        public string? Code { get; set; }
        [JsonProperty("description")]
        public object? Description { get; set; }
    }

    public class AddLinkedAccountRequest
    {
        [JsonProperty("getAllAvailableBanks")]
        public bool GetAllAvailableBanks { get; set; }

        [JsonProperty("preferredBanks")]
        public string[]? PreferredBanks { get; set; }
    }

    public class UpdateBVNForReservedAccountRequest
    {
        [JsonProperty("bvn")]
        public string BVN { get; set; }

        public UpdateBVNForReservedAccountRequest(string bvn)
        {
            BVN = bvn ?? throw new ArgumentNullException(nameof(bvn));
        }
    }

    public class AllowedPaymentSourceRequest
    {
        [JsonProperty("restrictPaymentSource")]
        public bool RestrictPaymentSource { get; set; }
        [JsonProperty("allowedPaymentSources")]
        public AllowedPaymentSources AllowedPaymentSources { get; set; }

        public AllowedPaymentSourceRequest(bool restrictPaymentSource, AllowedPaymentSources allowedPaymentSources)
        {
            RestrictPaymentSource = restrictPaymentSource;
            AllowedPaymentSources = allowedPaymentSources ?? throw new ArgumentNullException(nameof(allowedPaymentSources));  
        }
    }

    public class AllowedPaymentSources
    {
        [JsonProperty("bvns")]
        public string[]? BVNs { get; set; }
        [JsonProperty("bankAccounts")]
        public Account[]? BankAccounts { get; set; }
        [JsonProperty("accountNames")]
        public string[]? AccountNames { get; set; }
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
        public string? AccountNumber { get; set; }
        [JsonProperty("bankCode")]
        public string? BankCode { get; set; }
    }


    public class SplitConfigForReservedAccountRequest
    {
        [JsonProperty("configDetails")]
        public ConfigDetail[]? ConfigDetails { get; set; }
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
        public string? Code { get; set; }
        [JsonProperty("reservedAccountCode")]
        public string? ReservedAccountCode { get; set; }
        [JsonProperty("feeBearer")]
        public string? FeeBearer { get; set; }
        [JsonProperty("configDetails")]
        public ConfigDetail[]? ConfigDetails { get; set; }
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
        public ReservedAccountTransaction[]? Content { get; set; }
    }


    public class ReservedAccountTransaction
    {
        [JsonProperty("customerDTO")]
        public Customerdto? CustomerDTO { get; set; }
        [JsonProperty("providerAmount")]
        public float ProviderAmount { get; set; }
        [JsonProperty("paymentMethod")]
        public string? PaymentMethod { get; set; }
        [JsonProperty("createdOn")]
        public DateTime CreatedOn { get; set; }
        [JsonProperty("amount")]
        public float Amount { get; set; }
        [JsonProperty("flagged")]
        public bool Flagged { get; set; }
        [JsonProperty("providerCode")]
        public string? ProviderCode { get; set; }
        [JsonProperty("fee")]
        public float Fee { get; set; }
        [JsonProperty("currencyCode")]
        public string? CurrencyCode { get; set; }
        [JsonProperty("completedOn")]
        public DateTime CompletedOn { get; set; }
        [JsonProperty("paymentDescription")]
        public string? PaymentDescription { get; set; }
        [JsonProperty("paymentStatus")]
        public string? PaymentStatus { get; set; }
        [JsonProperty("transactionReference")]
        public string? TransactionReference { get; set; }
        [JsonProperty("paymentReference")]
        public string? PaymentReference { get; set; }
        [JsonProperty("merchantCode")]
        public string? MerchantCode { get; set; }
        [JsonProperty("merchantName")]
        public string? MerchantName { get; set; }
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
        public string? AccountReference { get; set; }
        [JsonProperty("accountName")]
        public string? AccountName { get; set; }
        [JsonProperty("customerEmail")]
        public string? CustomerEmail { get; set; }
        [JsonProperty("customerName")]
        public string? CustomerName { get; set; }
        [JsonProperty("bvn")]
        public string? BVN { get; set; }
    }
}