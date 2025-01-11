using Newtonsoft.Json;

namespace MonnifyDotnet.SDK.Models
{
    public class ChargeCardTokenRequest
    {
        [JsonProperty("cardToken")]
        public string CardToken { get; set; }

        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }

        [JsonProperty("paymentReference")]
        public string PaymentReference { get; set; }

        [JsonProperty("paymentDescription")]
        public string PaymentDescription { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("contractCode")]
        public string ContractCode { get; set; }

        [JsonProperty("apiKey")]
        public string ApiKey { get; set; }

        [JsonProperty("metaData")]
        public Metadata? MetaData { get; set; }

        [JsonProperty("incomeSplitConfig")]
        public IncomeSplitConfig[]? IncomeSplitConfig { get; set; }

        public ChargeCardTokenRequest(
            string cardToken,
            string customerName,
            string customerEmail,
            string paymentReference,
            string paymentDescription,
            string currencyCode,
            string contractCode,
            string apiKey)
        {
            CardToken = cardToken ?? throw new ArgumentNullException(nameof(cardToken));
            CustomerName = customerName ?? throw new ArgumentNullException(nameof(customerName));
            CustomerEmail = customerEmail ?? throw new ArgumentNullException(nameof(customerEmail));
            PaymentReference = paymentReference ?? throw new ArgumentNullException(nameof(paymentReference));
            PaymentDescription = paymentDescription ?? throw new ArgumentNullException(nameof(paymentDescription));
            CurrencyCode = currencyCode ?? throw new ArgumentNullException(nameof(currencyCode));
            ContractCode = contractCode ?? throw new ArgumentNullException(nameof(contractCode));
            ApiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
        }
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