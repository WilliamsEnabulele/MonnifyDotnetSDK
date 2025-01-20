using Newtonsoft.Json;

namespace MonnifyDotnet.SDK.Models
{
    public class SettlementFilterRequest
    {
        [JsonProperty("reference")]
        public string? Reference { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }
    }

    public class SettlementResponse
    {
        [JsonProperty("content")]
        public Settlement[]? Content { get; set; }
    }

    public class Settlement
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

        [JsonProperty("transactionHash")]
        public string? TransactionHash { get; set; }

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
        public SettlementMetadata? MetaData { get; set; }
    }

    public class SettlementMetadata
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("age")]
        public string? Age { get; set; }
    }

    public class SettlementInformationForTransactionResponse
    {
        [JsonProperty("transaction")]
        public Transaction? Transaction { get; set; }

        [JsonProperty("beneficiaries")]
        public Beneficiary[]? Beneficiaries { get; set; }
    }

    public class Beneficiary
    {
        [JsonProperty("beneficiaryType")]
        public string? BeneficiaryType { get; set; }

        [JsonProperty("beneficiaryCode")]
        public string? BeneficiaryCode { get; set; }

        [JsonProperty("beneficiaryIncome")]
        public float BeneficiaryIncome { get; set; }

        [JsonProperty("incurredFee")]
        public float IncurredFee { get; set; }

        [JsonProperty("settlementStatus")]
        public string? SettlementStatus { get; set; }

        [JsonProperty("settlementInformation")]
        public SettlementInformation? SettlementInformation { get; set; }
    }

    public class SettlementInformation
    {
        [JsonProperty("settledDate")]
        public DateTime SettledDate { get; set; }

        [JsonProperty("settlementReference")]
        public string? SettlementReference { get; set; }

        [JsonProperty("settlementAmount")]
        public float SettlementAmount { get; set; }

        [JsonProperty("settlementFee")]
        public float SettlementFee { get; set; }

        [JsonProperty("destinationAccountNumber")]
        public string? DestinationAccountNumber { get; set; }

        [JsonProperty("destinationAccountName")]
        public string? DestinationAccountName { get; set; }

        [JsonProperty("destinationBankName")]
        public string? DestinationBankName { get; set; }

        [JsonProperty("destinationBankCode")]
        public string? DestinationBankCode { get; set; }
    }
}