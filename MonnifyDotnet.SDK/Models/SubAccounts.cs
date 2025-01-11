using Newtonsoft.Json;

namespace MonnifyDotnetSDK.src.Models
{
    public class CreateSubAccountRequest
    {
        [JsonProperty("currencyCode")]
        public required string CurrencyCode { get; set; }

        [JsonProperty("bankCode")]
        public required string BankCode { get; set; }

        [JsonProperty("accountNumber")]
        public required string AccountNumber { get; set; }

        [JsonProperty("email")]
        public required string Email { get; set; }

        [JsonProperty("defaultSplitPercentage")]
        public required float DefaultSplitPercentage { get; set; }
    }

    public class SubAccountResponse
    {
        [JsonProperty("subAccountCode")]
        public string? SubAccountCode { get; set; }

        [JsonProperty("accountNumber")]
        public string? AccountNumber { get; set; }

        [JsonProperty("accountName")]
        public string? AccountName { get; set; }

        [JsonProperty("currencyCode")]
        public string? CurrencyCode { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("bankCode")]
        public string? BankCode { get; set; }

        [JsonProperty("bankName")]
        public string? BankName { get; set; }

        [JsonProperty("defaultSplitPercentage")]
        public float DefaultSplitPercentage { get; set; }

        [JsonProperty("settlementProfileCode")]
        public string? SettlementProfileCode { get; set; }

        [JsonProperty("settlementReportEmails")]
        public object[]? SettlementReportEmails { get; set; }
    }

    public class UpdateSubAccountRequest
    {
        [JsonProperty("subAccountCode")]
        public required string SubAccountCode { get; set; }

        [JsonProperty("currencyCode")]
        public required string CurrencyCode { get; set; }

        [JsonProperty("bankCode")]
        public required string BankCode { get; set; }

        [JsonProperty("accountNumber")]
        public required string AccountNumber { get; set; }

        [JsonProperty("email")]
        public required string Email { get; set; }

        [JsonProperty("defaultSplitPercentage")]
        public required float DefaultSplitPercentage { get; set; }
    }


}