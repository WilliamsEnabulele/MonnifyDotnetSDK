using Newtonsoft.Json;

namespace MonnifyDotnetSDK.src.Models
{
    public class CreateInvoiceRequest
    {
        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("invoiceReference")]
        public required string InvoiceReference { get; set; }

        [JsonProperty("description")]
        public required string Description { get; set; }

        [JsonProperty("currencyCode")]
        public required string CurrencyCode { get; set; }

        [JsonProperty("contractCode")]
        public required string ContractCode { get; set; }

        [JsonProperty("customerEmail")]
        public required string CustomerEmail { get; set; }

        [JsonProperty("customerName")]
        public required string CustomerName { get; set; }

        [JsonProperty("expiryDate")]
        public required string ExpiryDate { get; set; }

        [JsonProperty("paymentMethods")]
        public object[]? PaymentMethods { get; set; }

        [JsonProperty("incomeSplitConfig")]
        public IncomeSplitConfig[]? IncomeSplitConfig { get; set; }

        [JsonProperty("redirectUrl")]
        public string? RedirectUrl { get; set; }
    }

    public class IncomeSplitConfig
    {
        [JsonProperty("subAccountCode")]
        public required string SubAccountCode { get; set; }

        [JsonProperty("feePercentage")]
        public float FeePercentage { get; set; }

        [JsonProperty("splitAmount")]
        public float SplitAmount { get; set; }

        [JsonProperty("feeBearer")]
        public bool FeeBearer { get; set; }
    }

    public class InvoiceResponse
    {
        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("invoiceReference")]
        public string? InvoiceReference { get; set; }

        [JsonProperty("invoiceStatus")]
        public string? InvoiceStatus { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("contractCode")]
        public string? ContractCode { get; set; }

        [JsonProperty("customerEmail")]
        public string? CustomerEmail { get; set; }

        [JsonProperty("customerName")]
        public string? CustomerName { get; set; }

        [JsonProperty("expiryDate")]
        public string? ExpiryDate { get; set; }

        [JsonProperty("createdBy")]
        public string? CreatedBy { get; set; }

        [JsonProperty("createdOn")]
        public string? CreatedOn { get; set; }

        [JsonProperty("checkoutUrl")]
        public string? CheckoutUrl { get; set; }

        [JsonProperty("accountNumber")]
        public string? AccountNumber { get; set; }

        [JsonProperty("accountName")]
        public string? AccountName { get; set; }

        [JsonProperty("bankName")]
        public string? BankName { get; set; }

        [JsonProperty("bankCode")]
        public string? BankCode { get; set; }

        [JsonProperty("redirectUrl")]
        public string? RedirectUrl { get; set; }

        [JsonProperty("transactionReference")]
        public string? TransactionReference { get; set; }

        [JsonProperty("incomeSplitConfig")]
        public IncomeSplitConfig[]? IncomeSplitConfig { get; set; }
    }

    public class GetAllInvoicesResponse
    {
        [JsonProperty("content")]
        public GetAllInvoice[]? Content { get; set; }
    }

    public class GetAllInvoice
    {
        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("invoiceReference")]
        public string? InvoiceReference { get; set; }

        [JsonProperty("invoiceStatus")]
        public string? InvoiceStatus { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("contractCode")]
        public string? ContractCode { get; set; }

        [JsonProperty("customerEmail")]
        public string? CustomerEmail { get; set; }

        [JsonProperty("customerName")]
        public string? CustomerName { get; set; }

        [JsonProperty("expiryDate")]
        public string? ExpiryDate { get; set; }

        [JsonProperty("createdBy")]
        public string? CreatedBy { get; set; }

        [JsonProperty("createdOn")]
        public string? CreatedOn { get; set; }

        [JsonProperty("accountNumber")]
        public string? AccountNumber { get; set; }

        [JsonProperty("bankName")]
        public string? BankName { get; set; }

        [JsonProperty("bankCode")]
        public string? BankCode { get; set; }
    }

    public class CancelAnInvoiceResponse
    {
        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("invoiceReference")]
        public string? InvoiceReference { get; set; }

        [JsonProperty("invoiceStatus")]
        public string? InvoiceStatus { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("contractCode")]
        public string? ContractCode { get; set; }

        [JsonProperty("customerEmail")]
        public string? CustomerEmail { get; set; }

        [JsonProperty("customerName")]
        public string? CustomerName { get; set; }

        [JsonProperty("expiryDate")]
        public string? ExpiryDate { get; set; }

        [JsonProperty("createdBy")]
        public string? CreatedBy { get; set; }

        [JsonProperty("createdOn")]
        public string? CreatedOn { get; set; }

        [JsonProperty("accountNumber")]
        public string? AccountNumber { get; set; }

        [JsonProperty("bankName")]
        public string? BankName { get; set; }

        [JsonProperty("bankCode")]
        public string? BankCode { get; set; }
    }

    public class AttachReserveAccountInvoiceRequest
    {
        [JsonProperty("amount")]
        public required float Amount { get; set; }

        [JsonProperty("invoiceReference")]
        public required string InvoiceReference { get; set; }

        [JsonProperty("accountReference")]
        public required string AccountReference { get; set; }

        [JsonProperty("description")]
        public required string Description { get; set; }

        [JsonProperty("currencyCode")]
        public required string CurrencyCode { get; set; }

        [JsonProperty("contractCode")]
        public required string ContractCode { get; set; }

        [JsonProperty("customerEmail")]
        public required string CustomerEmail { get; set; }

        [JsonProperty("customerName")]
        public required string CustomerName { get; set; }
        [JsonProperty("incomeSplitConfig")]
        public IncomeSplitConfig[]? IncomeSplitConfig { get; set; }

        [JsonProperty("expiryDate")]
        public required string ExpiryDate { get; set; }
    }

    public class AttachReserveAccountInvoiceResponse
    {
        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("invoiceReference")]
        public string? InvoiceReference { get; set; }

        [JsonProperty("invoiceStatus")]
        public string? InvoiceStatus { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("contractCode")]
        public string? ContractCode { get; set; }

        [JsonProperty("customerEmail")]
        public string? CustomerEmail { get; set; }

        [JsonProperty("customerName")]
        public string? CustomerName { get; set; }

        [JsonProperty("expiryDate")]
        public string? ExpiryDate { get; set; }

        [JsonProperty("createdBy")]
        public string? CreatedBy { get; set; }

        [JsonProperty("createdOn")]
        public string? CreatedOn { get; set; }

        [JsonProperty("checkoutUrl")]
        public string? CheckoutUrl { get; set; }

        [JsonProperty("accountNumber")]
        public string? AccountNumber { get; set; }

        [JsonProperty("accountName")]
        public string? AccountName { get; set; }

        [JsonProperty("bankName")]
        public string? BankName { get; set; }

        [JsonProperty("bankCode")]
        public string? BankCode { get; set; }
    }
}