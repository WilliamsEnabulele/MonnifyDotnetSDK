using Newtonsoft.Json;

namespace MonnifyDotnet.SDK.Models
{
    public class InitiatizeTransaction
    {
        [JsonProperty("amount")]
        public required float Amount { get; set; }

        [JsonProperty("customerName")]
        public string? CustomerName { get; set; }

        [JsonProperty("customerEmail")]
        public required string CustomerEmail { get; set; }

        [JsonProperty("paymentReference")]
        public required string PaymentReference { get; set; }

        [JsonProperty("paymentDescription")]
        public string? PaymentDescription { get; set; }

        [JsonProperty("currencyCode")]
        public required string CurrencyCode { get; set; }

        [JsonProperty("contractCode")]
        public required string ContractCode { get; set; }

        [JsonProperty("redirectUrl")]
        public string? RedirectUrl { get; set; }

        [JsonProperty("paymentMethods")]
        public string[] PaymentMethods { get; set; } = [];
        [JsonProperty("incomeSplitConfig")]
        public IncomeSplitConfig? IncomeSplitConfig { get; set; }
        [JsonProperty("metaData")]
        public Dictionary<string, object>? MetaData { get; set; }
    }

    public class InitiateTransactionResponse
    {
        [JsonProperty("transactionReference")]
        public string? TransactionReference { get; set; }

        [JsonProperty("paymentReference")]
        public string? PaymentReference { get; set; }

        [JsonProperty("merchantName")]
        public string? MerchantName { get; set; }

        [JsonProperty("apiKey")]
        public string? ApiKey { get; set; }

        [JsonProperty("enabledPaymentMethod")]
        public string[] EnabledPaymentMethod { get; set; } = [];

        [JsonProperty("checkoutUrl")]
        public string? CheckoutUrl { get; set; }
    }

    public class PayWithBankTransfer
    {
        [JsonProperty("transactionReference")]
        public required string TransactionReference { get; set; }

        [JsonProperty("bankCode")]
        public string? BankCode { get; set; }
    }

    public class PayWithBankTransferResponse
    {
        [JsonProperty("accountNumber")]
        public string? AccountNumber { get; set; }

        [JsonProperty("accountName")]
        public string? AccountName { get; set; }

        [JsonProperty("bankName")]
        public string? BankName { get; set; }

        [JsonProperty("bankCode")]
        public string? BankCode { get; set; }

        [JsonProperty("accountDurationSeconds")]
        public int AccountDurationSeconds { get; set; }

        [JsonProperty("ussdPayment")]
        public string? USSDPayment { get; set; }

        [JsonProperty("requestTime")]
        public DateTime RequestTime { get; set; }

        [JsonProperty("expiresOn")]
        public DateTime ExpiresOn { get; set; }

        [JsonProperty("incomeSplitConfig ")]
        public string? IncomeSplitConfig { get; set; }

        [JsonProperty("paymentReference")]
        public string? PaymentReference { get; set; }

        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("fee")]
        public float Fee { get; set; }

        [JsonProperty("totalPayable")]
        public float TotalPayable { get; set; }

        [JsonProperty("collectionChannel")]
        public string? CollectionChannel { get; set; }

        [JsonProperty("productInformation")]
        public object? ProductInformation { get; set; }
    }

    public class PayWithUSSD
    {
        [JsonProperty("transactionReference")]
        public required string TransactionReference { get; set; }

        [JsonProperty("bankUssdCode")]
        public required string BankUssdCode { get; set; }
    }

    public class ChargeCard
    {
        [JsonProperty("transactionReference")]
        public required string TransactionReference { get; set; }

        [JsonProperty("collectionChannel")]
        public required string CollectionChannel { get; set; }

        [JsonProperty("card")]
        public Card? Card { get; set; }
    }

    public class Card
    {
        [JsonProperty("number")]
        public required string Number { get; set; }

        [JsonProperty("expiryMonth")]
        public required string ExpiryMonth { get; set; }

        [JsonProperty("expiryYear")]
        public required string ExpiryYear { get; set; }

        [JsonProperty("pin")]
        public required string Pin { get; set; }

        [JsonProperty("cvv")]
        public required string CVV { get; set; }
    }

    public class ChargeCardResponse
    {
        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("message")]
        public string? Message { get; set; }

        [JsonProperty("transactionReference")]
        public string? TransactionReference { get; set; }

        [JsonProperty("paymentReference")]
        public string? PaymentReference { get; set; }

        [JsonProperty("authorizedAmount")]
        public float AuthorizedAmount { get; set; }
    }

    public class AuthorizeOTP
    {
        [JsonProperty("transactionReference")]
        public required string TransactionReference { get; set; }

        [JsonProperty("collectionChannel")]
        public required string CollectionChannel { get; set; }

        [JsonProperty("tokenId")]
        public required string TokenId { get; set; }

        [JsonProperty("token")]
        public required string Token { get; set; }
    }

    public class AuthorizeOTPResponse
    {
        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("message")]
        public string? Message { get; set; }

        [JsonProperty("transactionReference")]
        public string? TransactionReference { get; set; }

        [JsonProperty("paymentReference")]
        public string? PaymentReference { get; set; }

        [JsonProperty("authorizedAmount")]
        public float AuthorizedAmount { get; set; }
    }

    public class Authorize3DSCard
    {
        [JsonProperty("transactionReference")]
        public required string TransactionReference { get; set; }

        [JsonProperty("collectionChannel")]
        public string? CollectionChannel { get; set; }

        [JsonProperty("card")]
        public required Card Card { get; set; }
    }

    public class Authorize3DSCardResponse
    {
        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("message")]
        public string? Message { get; set; }

        [JsonProperty("secure3dData")]
        public Secure3DData? Secure3dData { get; set; }

        [JsonProperty("transactionReference")]
        public string? TransactionReference { get; set; }

        [JsonProperty("paymentReference")]
        public string? PaymentReference { get; set; }

        [JsonProperty("authorizedAmount")]
        public float AuthorizedAmount { get; set; }
    }

    public class Secure3DData
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("redirectUrl")]
        public string? RedirectUrl { get; set; }
    }

    public class GetAllTransactions
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("paymentReference")]
        public string? PaymentReference { get; set; }

        [JsonProperty("fromFilter")]
        public float FromFilter { get; set; }

        [JsonProperty("toFilter")]
        public float ToFilter { get; set; }

        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("customerName")]
        public string? CustomerName { get; set; }

        [JsonProperty("customerEmail")]
        public string? CustomerEmail { get; set; }

        [JsonProperty("paymentStatus")]
        public string? PaymentStatus { get; set; }

        [JsonProperty("from")]
        public DateTime From { get; set; }

        [JsonProperty("to")]
        public DateTime To { get; set; }
    }

    public class GetAllTransactionsResponse
    {
        [JsonProperty("content")]
        public List<Transaction> Content { get; set; } = [];
    }

    public class Transaction
    {
        [JsonProperty("customerDTO")]
        public Customerdto? CustomerDTO { get; set; }

        [JsonProperty("createdOn")]
        public DateTime CreatedOn { get; set; }

        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("flagged")]
        public bool Flagged { get; set; }

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

        [JsonProperty("metaData")]
        public object? MetaData { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("paymentMethodList")]
        public string[] PaymentMethodList { get; set; } = [];

        [JsonProperty("collectionChannel")]
        public string? CollectionChannel { get; set; }
    }

    public class Customerdto
    {
        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("merchantCode")]
        public string? MerchantCode { get; set; }
    }

    public class TransactionStatus
    {
        [JsonProperty("transactionReference")]
        public string? TransactionReference { get; set; }
    }

    public class TransactionStatusResponse
    {
        [JsonProperty("transactionReference")]
        public string? TransactionReference { get; set; }

        [JsonProperty("paymentReference")]
        public string? PaymentReference { get; set; }

        [JsonProperty("amountPaid")]
        public string? AmountPaid { get; set; }

        [JsonProperty("totalPayable")]
        public string? TotalPayable { get; set; }

        [JsonProperty("settlementAmount")]
        public string? SettlementAmount { get; set; }

        [JsonProperty("paidOn")]
        public string? PaidOn { get; set; }

        [JsonProperty("paymentStatus")]
        public string? PaymentStatus { get; set; }

        [JsonProperty("paymentDescription")]
        public string? PaymentDescription { get; set; }

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("paymentMethod")]
        public string? PaymentMethod { get; set; }

        [JsonProperty("product")]
        public Product? Product { get; set; }

        [JsonProperty("cardDetails")]
        public CardDetails? CardDetails { get; set; }

        [JsonProperty("accountDetails")]
        public object? AccountDetails { get; set; }

        [JsonProperty("accountPayments")]
        public object[]? AccountPayments { get; set; }

        [JsonProperty("customer")]
        public Customer? Customer { get; set; }

        [JsonProperty("metaData")]
        public object? MetaData { get; set; }
    }

    public class Product
    {
        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("reference")]
        public string? Reference { get; set; }
    }

    public class CardDetails
    {
        [JsonProperty("cardType")]
        public string? CardType { get; set; }

        [JsonProperty("last4")]
        public string? Last4 { get; set; }

        [JsonProperty("expMonth")]
        public string? ExpMonth { get; set; }

        [JsonProperty("expYear")]
        public string? ExpYear { get; set; }

        [JsonProperty("bin")]
        public string? Bin { get; set; }

        [JsonProperty("bankCode")]
        public string? BankCode { get; set; }

        [JsonProperty("bankName")]
        public string? BankName { get; set; }

        [JsonProperty("reusable")]
        public bool Reusable { get; set; }

        [JsonProperty("countryCode")]
        public string? CountryCode { get; set; }

        [JsonProperty("cardToken")]
        public string? CardToken { get; set; }

        [JsonProperty("supportsTokenization")]
        public bool SupportsTokenization { get; set; }

        [JsonProperty("maskedPan")]
        public string? MaskedPan { get; set; }
    }

    public class Customer
    {
        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }
    }

    public class TransactionStatusByReference
    {

        [JsonProperty("transactionReference")]
        public string? TransactionReference { get; set; }

        [JsonProperty("paymentReference")]
        public string? PaymentReference { get; set; }
    }
}