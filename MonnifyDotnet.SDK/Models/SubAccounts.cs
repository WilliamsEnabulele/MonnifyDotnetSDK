using Newtonsoft.Json;

namespace MonnifyDotnet.SDK.Models
{
    public class CreateSubAccountRequest
    {
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("bankCode")]
        public string BankCode { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("defaultSplitPercentage")]
        public float DefaultSplitPercentage { get; set; }

        public CreateSubAccountRequest(
            string currencyCode,
            string bankCode,
            string accountNumber,
            string email,
            float defaultSplitPercentage)
        {
            CurrencyCode = currencyCode ?? throw new ArgumentNullException(nameof(currencyCode));
            BankCode = bankCode ?? throw new ArgumentNullException(nameof(bankCode));
            AccountNumber = accountNumber ?? throw new ArgumentNullException(nameof(accountNumber));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            DefaultSplitPercentage = defaultSplitPercentage;
        }
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
        public string SubAccountCode { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("bankCode")]
        public string BankCode { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("defaultSplitPercentage")]
        public float DefaultSplitPercentage { get; set; }

        public UpdateSubAccountRequest(
            string subAccountCode,
            string currencyCode,
            string bankCode,
            string accountNumber,
            string email,
            float defaultSplitPercentage)
        {
            SubAccountCode = subAccountCode ?? throw new ArgumentNullException(nameof(subAccountCode));
            CurrencyCode = currencyCode ?? throw new ArgumentNullException(nameof(currencyCode));
            BankCode = bankCode ?? throw new ArgumentNullException(nameof(bankCode));
            AccountNumber = accountNumber ?? throw new ArgumentNullException(nameof(accountNumber));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            DefaultSplitPercentage = defaultSplitPercentage;
        }
    }
}