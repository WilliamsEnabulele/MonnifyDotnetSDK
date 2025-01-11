using Newtonsoft.Json;

namespace MonnifyDotnetSDK.src.Models
{

    public class InitiateRefundRequest
    {
        [JsonProperty("transactionReference")]
        public required string TransactionReference { get; set; }

        [JsonProperty("refundReference")]
        public required string RefundReference { get; set; }

        [JsonProperty("refundAmount")]
        public required float RefundAmount { get; set; }

        [JsonProperty("refundReason")]
        public required string RefundReason { get; set; }

        [JsonProperty("customerNote")]
        public required string CustomerNote { get; set; }

        [JsonProperty("destinationAccountNumber")]
        public string? DestinationAccountNumber { get; set; }

        [JsonProperty("destinationAccountBankCode")]
        public string? DestinationAccountBankCode { get; set; }
    }

    public class RefundsResponse
    {
        [JsonProperty("content")]
        public required RefundResponse[] Content { get; set; }
    }

    public class RefundResponse
    {
        [JsonProperty("refundReference")]
        public string? RefundReference { get; set; }

        [JsonProperty("transactionReference")]
        public string? TransactionReference { get; set; }

        [JsonProperty("refundReason")]
        public string? RefundReason { get; set; }

        [JsonProperty("customerNote")]
        public string? CustomerNote { get; set; }

        [JsonProperty("refundAmount")]
        public float RefundAmount { get; set; }

        [JsonProperty("refundType")]
        public string? RefundType { get; set; }

        [JsonProperty("refundStatus")]
        public required string RefundStatus { get; set; }

        [JsonProperty("refundStrategy")]
        public string? RefundStrategy { get; set; }

        [JsonProperty("comment")]
        public string? Comment { get; set; }

        [JsonProperty("completedOn")]
        public string? CompletedOn { get; set; }

        [JsonProperty("createdOn")]
        public string? CreatedOn { get; set; }
    }
}