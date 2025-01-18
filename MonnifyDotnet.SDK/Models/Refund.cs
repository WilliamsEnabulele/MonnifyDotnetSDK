using Newtonsoft.Json;

namespace MonnifyDotnet.SDK.Models
{
    public class InitiateRefundRequest
    {
        [JsonProperty("transactionReference")]
        public string TransactionReference { get; set; }

        [JsonProperty("refundReference")]
        public string RefundReference { get; set; }

        [JsonProperty("refundAmount")]
        public float RefundAmount { get; set; }

        [JsonProperty("refundReason")]
        public string RefundReason { get; set; }

        [JsonProperty("customerNote")]
        public string CustomerNote { get; set; }

        [JsonProperty("destinationAccountNumber")]
        public string? DestinationAccountNumber { get; set; }

        [JsonProperty("destinationAccountBankCode")]
        public string? DestinationAccountBankCode { get; set; }

        public InitiateRefundRequest(
            string transactionReference,
            string refundReference,
            float refundAmount,
            string refundReason,
            string customerNote)
        {
            TransactionReference = transactionReference ?? throw new ArgumentNullException(nameof(transactionReference));
            RefundReference = refundReference ?? throw new ArgumentNullException(nameof(refundReference));
            RefundAmount = refundAmount;
            RefundReason = refundReason ?? throw new ArgumentNullException(nameof(refundReason));
            CustomerNote = customerNote ?? throw new ArgumentNullException(nameof(customerNote));
        }
    }

    public class RefundsResponse
    {
        [JsonProperty("content")]
        public RefundResponse[]? Content { get; set; }
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
        public string? RefundStatus { get; set; }

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