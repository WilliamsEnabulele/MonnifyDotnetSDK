using Newtonsoft.Json;

namespace MonnifyDotnet.SDK.Models
{
    public class CreateInvoiceRequest
    {
        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("invoiceReference")]
        public string InvoiceReference { get; set; }  // removed 'required'

        [JsonProperty("description")]
        public string Description { get; set; }  // removed 'required'

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }  // removed 'required'

        [JsonProperty("contractCode")]
        public string ContractCode { get; set; }  // removed 'required'

        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }  // removed 'required'

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }  // removed 'required'

        [JsonProperty("expiryDate")]
        public string ExpiryDate { get; set; }  // removed 'required'

        [JsonProperty("paymentMethods")]
        public object[]? PaymentMethods { get; set; }

        [JsonProperty("incomeSplitConfig")]
        public IncomeSplitConfig[]? IncomeSplitConfig { get; set; }

        [JsonProperty("redirectUrl")]
        public string? RedirectUrl { get; set; }

        public CreateInvoiceRequest(
            string invoiceReference, string description, string currencyCode,
            string contractCode, string customerEmail, string customerName,
            string expiryDate)
        {
            InvoiceReference = invoiceReference ?? throw new ArgumentNullException(nameof(invoiceReference));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            CurrencyCode = currencyCode ?? throw new ArgumentNullException(nameof(currencyCode));
            ContractCode = contractCode ?? throw new ArgumentNullException(nameof(contractCode));
            CustomerEmail = customerEmail ?? throw new ArgumentNullException(nameof(customerEmail));
            CustomerName = customerName ?? throw new ArgumentNullException(nameof(customerName));
            ExpiryDate = expiryDate ?? throw new ArgumentNullException(nameof(expiryDate));
        }
    }

    public class IncomeSplitConfig
    {
        [JsonProperty("subAccountCode")]
        public string SubAccountCode { get; set; }  // removed 'required'

        [JsonProperty("feePercentage")]
        public float FeePercentage { get; set; }

        [JsonProperty("splitAmount")]
        public float SplitAmount { get; set; }

        [JsonProperty("feeBearer")]
        public bool FeeBearer { get; set; }

        public IncomeSplitConfig(string subAccountCode, float feePercentage, float splitAmount, bool feeBearer)
        {
            SubAccountCode = subAccountCode ?? throw new ArgumentNullException(nameof(subAccountCode));
            FeePercentage = feePercentage;
            SplitAmount = splitAmount;
            FeeBearer = feeBearer;
        }
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
        public float Amount { get; set; }

        [JsonProperty("invoiceReference")]
        public string InvoiceReference { get; set; }

        [JsonProperty("accountReference")]
        public string AccountReference { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("contractCode")]
        public string ContractCode { get; set; }

        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("incomeSplitConfig")]
        public IncomeSplitConfig[]? IncomeSplitConfig { get; set; }

        [JsonProperty("expiryDate")]
        public string ExpiryDate { get; set; }

        public AttachReserveAccountInvoiceRequest(
            float amount,
            string invoiceReference,
            string accountReference,
            string description,
            string currencyCode,
            string contractCode,
            string customerEmail,
            string customerName,
            string expiryDate)
        {
            Amount = amount;
            InvoiceReference = invoiceReference ?? throw new ArgumentNullException(nameof(invoiceReference));
            AccountReference = accountReference ?? throw new ArgumentNullException(nameof(accountReference));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            CurrencyCode = currencyCode ?? throw new ArgumentNullException(nameof(currencyCode));
            ContractCode = contractCode ?? throw new ArgumentNullException(nameof(contractCode));
            CustomerEmail = customerEmail ?? throw new ArgumentNullException(nameof(customerEmail));
            CustomerName = customerName ?? throw new ArgumentNullException(nameof(customerName));
            ExpiryDate = expiryDate ?? throw new ArgumentNullException(nameof(expiryDate));
        }
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