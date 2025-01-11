using Newtonsoft.Json;

namespace MonnifyDotnetSDK.src.Models
{
    public class ChargeCardTokenRequest
    {
        [JsonProperty("cardToken")]
        public required string CardToken { get; set; }

        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("customerName")]
        public required string CustomerName { get; set; }

        [JsonProperty("customerEmail")]
        public required string CustomerEmail { get; set; }

        [JsonProperty("paymentReference")]
        public required string PaymentReference { get; set; }

        [JsonProperty("paymentDescription")]
        public required string PaymentDescription { get; set; }

        [JsonProperty("currencyCode")]
        public required string CurrencyCode { get; set; }

        [JsonProperty("contractCode")]
        public required string ContractCode { get; set; }

        [JsonProperty("apiKey")]
        public required string ApiKey { get; set; }

        [JsonProperty("metaData")]
        public Metadata? MetaData { get; set; }

        [JsonProperty("incomeSplitConfig")]
        public IncomeSplitConfig[]? IncomeSplitConfig { get; set; }
    }

    public class Metadata
    {
        [JsonProperty("ipAddress")]
        public string? IpAddress { get; set; }

        [JsonProperty("deviceType")]
        public string? DeviceType { get; set; }
    }

    public class LimitProfileConfig
    {
        [JsonProperty("limitProfileCode")]
        public string? LimitProfileCode { get; set; }

        [JsonProperty("singleTransactionValue")]
        public float SingleTransactionValue { get; set; }

        [JsonProperty("dailyTransactionVolume")]
        public float DailyTransactionVolume { get; set; }

        [JsonProperty("dailyTransactionValue")]
        public float DailyTransactionValue { get; set; }
    }
}