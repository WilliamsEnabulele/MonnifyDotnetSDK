using Newtonsoft.Json;

namespace MonnifyDotnet.SDK.Models
{
    public class CreateMandateRequest
    {
        [JsonProperty("contractCode")]
        public string? ContractCode { get; set; }

        [JsonProperty("mandateReference")]
        public string? MandateReference { get; set; }

        [JsonProperty("autoRenew")]
        public bool AutoRenew { get; set; }

        [JsonProperty("customerCancellation")]
        public bool CustomerCancellation { get; set; }

        [JsonProperty("customerName")]
        public string? CustomerName { get; set; }

        [JsonProperty("customerPhoneNumber")]
        public string? CustomerPhoneNumber { get; set; }

        [JsonProperty("customerEmailAddress")]
        public string? CustomerEmailAddress { get; set; }

        [JsonProperty("customerAddress")]
        public string? CustomerAddress { get; set; }

        [JsonProperty("customerAccountName")]
        public string? CustomerAccountName { get; set; }

        [JsonProperty("customerAccountNumber")]
        public string? CustomerAccountNumber { get; set; }

        [JsonProperty("customerAccountBankCode")]
        public string? CustomerAccountBankCode { get; set; }

        [JsonProperty("mandateDescription")]
        public string? MandateDescription { get; set; }

        [JsonProperty("mandateStartDate")]
        public DateTime MandateStartDate { get; set; }

        [JsonProperty("mandateEndDate")]
        public DateTime MandateEndDate { get; set; }
    }

    public class MandateResponse
    {
        [JsonProperty("responseMessage")]
        public string? ResponseMessage { get; set; }

        [JsonProperty("mandateReference")]
        public string? MandateReference { get; set; }

        [JsonProperty("mandateCode")]
        public string? MandateCode { get; set; }

        [JsonProperty("mandateStatus")]
        public string? MandateStatus { get; set; }
    }

    public class GetMandateStatusResponse
    {
        [JsonProperty("mandateCode")]
        public string? MandateCode { get; set; }

        [JsonProperty("externalMandateReference")]
        public string? ExternalMandateReference { get; set; }

        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }

        [JsonProperty("endDate")]
        public DateTime EndDate { get; set; }

        [JsonProperty("mandateStatus")]
        public string? MandateStatus { get; set; }

        [JsonProperty("mandateAmount")]
        public float MandateAmount { get; set; }

        [JsonProperty("contractCode")]
        public string? ContractCode { get; set; }

        [JsonProperty("autoRenew")]
        public bool AutoRenew { get; set; }

        [JsonProperty("customerPhoneNumber")]
        public string? CustomerPhoneNumber { get; set; }

        [JsonProperty("customerEmailAddress")]
        public string? CustomerEmailAddress { get; set; }

        [JsonProperty("customerAddress")]
        public string? CustomerAddress { get; set; }

        [JsonProperty("customerName")]
        public string? CustomerName { get; set; }

        [JsonProperty("customerAccountName")]
        public string? CustomerAccountName { get; set; }

        [JsonProperty("customerAccountNumber")]
        public string? CustomerAccountNumber { get; set; }

        [JsonProperty("customerAccountBankCode")]
        public string? CustomerAccountBankCode { get; set; }

        [JsonProperty("mandateDescription")]
        public string? MandateDescription { get; set; }

        [JsonProperty("debitAmount")]
        public object? DebitAmount { get; set; }

        [JsonProperty("authorizationMessage")]
        public object? AuthorizationMessage { get; set; }

        [JsonProperty("authorizationLink")]
        public object? AuthorizationLink { get; set; }
    }

    public class DebitMandateRequest
    {
        [JsonProperty("paymentReference")]
        public string? PaymentReference { get; set; }

        [JsonProperty("mandateCode")]
        public string? MandateCode { get; set; }

        [JsonProperty("debitAmount")]
        public float DebitAmount { get; set; }

        [JsonProperty("narration")]
        public string? Narration { get; set; }

        [JsonProperty("customerEmail")]
        public string? CustomerEmail { get; set; }
    }

    public class DebitMandateResponse
    {
        [JsonProperty("transactionStatus")]
        public string? TransactionStatus { get; set; }

        [JsonProperty("responseMessage")]
        public string? ResponseMessage { get; set; }

        [JsonProperty("transactionReference")]
        public string? TransactionReference { get; set; }

        [JsonProperty("paymentReference")]
        public string? PaymentReference { get; set; }

        [JsonProperty("debitAmount")]
        public float DebitAmount { get; set; }

        [JsonProperty("narration")]
        public string? Narration { get; set; }

        [JsonProperty("mandateCode")]
        public string? MandateCode { get; set; }
    }
}