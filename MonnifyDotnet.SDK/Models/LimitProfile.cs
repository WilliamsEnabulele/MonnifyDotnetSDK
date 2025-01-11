using Newtonsoft.Json;

namespace MonnifyDotnetSDK.src.Models
{

    public class LimitProfileRequest
    {
        [JsonProperty("limitProfileName")]
        public required string LimitProfileName { get; set; }

        [JsonProperty("singleTransactionValue")]
        public float SingleTransactionValue { get; set; }

        [JsonProperty("dailyTransactionVolume")]
        public float DailyTransactionVolume { get; set; }

        [JsonProperty("dailyTransactionValue")]
        public float DailyTransactionValue { get; set; }
    }

    public class GetLimitProfilesResponse
    {
        [JsonProperty("content")]
        public LimitProfileResponse[]? Content { get; set; }
    }

    public class LimitProfileResponse
    {
        [JsonProperty("limitProfileCode")]
        public string? LimitProfileCode { get; set; }

        [JsonProperty("limitProfileName")]
        public string? LimitProfileName { get; set; }

        [JsonProperty("singleTransactionValue")]
        public float SingleTransactionValue { get; set; }

        [JsonProperty("dailyTransactionVolume")]
        public float DailyTransactionVolume { get; set; }

        [JsonProperty("dailyTransactionValue")]
        public float DailyTransactionValue { get; set; }

        [JsonProperty("dateCreated")]
        public string? DateCreated { get; set; }

        [JsonProperty("lastModified")]
        public string? LastModified { get; set; }
    }

    public class ReserveAccountWithLimit
    {
        [JsonProperty("contractCode")]
        public string? ContractCode { get; set; }

        [JsonProperty("accountName")]
        public string? AccountName { get; set; }

        [JsonProperty("currencyCode")]
        public string? CurrencyCode { get; set; }

        [JsonProperty("accountReference")]
        public string? AccountReference { get; set; }

        [JsonProperty("customerEmail")]
        public string? CustomerEmail { get; set; }

        [JsonProperty("customerName")]
        public string? CustomerName { get; set; }

        [JsonProperty("limitProfileCode")]
        public string? LimitProfileCode { get; set; }
    }

    public class ReserveAccountWithLimitResponse
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

        [JsonProperty("accountNumber")]
        public string? AccountNumber { get; set; }

        [JsonProperty("bankName")]
        public string? BankName { get; set; }

        [JsonProperty("bankCode")]
        public string? BankCode { get; set; }

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

        [JsonProperty("restrictPaymentSource")]
        public bool? RestrictPaymentSource { get; set; }

        [JsonProperty("limitProfileConfig")]
        public LimitProfileConfig? LimitProfileConfig { get; set; }
    }

    public class UpdateReserveAccountLimitRequest
    {
        [JsonProperty("accountReference")]
        public string? AccountReference { get; set; }

        [JsonProperty("limitProfileCode")]
        public string? LimitProfileCode { get; set; }
    }


}