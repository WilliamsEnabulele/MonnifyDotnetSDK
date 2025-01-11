using Newtonsoft.Json;

namespace MonnifyDotnet.SDK.Models
{

    public class CreatePayCodeRequest
    {
        [JsonProperty("beneficiaryName")]
        public string BeneficiaryName { get; set; }

        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("paycodeReference")]
        public string PaycodeReference { get; set; }

        [JsonProperty("expiryDate")]
        public string ExpiryDate { get; set; }

        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        public CreatePayCodeRequest(
            string beneficiaryName,
            float amount,
            string paycodeReference,
            string expiryDate,
            string clientId)
        {
            BeneficiaryName = beneficiaryName ?? throw new ArgumentNullException(nameof(beneficiaryName));
            Amount = amount;
            PaycodeReference = paycodeReference ?? throw new ArgumentNullException(nameof(paycodeReference));
            ExpiryDate = expiryDate ?? throw new ArgumentNullException(nameof(expiryDate));
            ClientId = clientId ?? throw new ArgumentNullException(nameof(clientId));
        }
    }

    public class FetchPaycodeFilterRequest
    {
        [JsonProperty("transactionReference")]
        public string? TransactionReference { get; set; }

        [JsonProperty("beneficiaryName")]
        public string? BeneficiaryName { get; set; }

        [JsonProperty("transactionStatus")]
        public string? TransactionStatus { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }
    }

    public class Pageable
    {
        [JsonProperty("sort")]
        public Sort? Sort { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("unpaged")]
        public bool Unpaged { get; set; }

        [JsonProperty("paged")]
        public bool Paged { get; set; }
    }

    public class Sort
    {
        [JsonProperty("sorted")]
        public bool Sorted { get; set; }

        [JsonProperty("unsorted")]
        public bool Unsorted { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }
    }

    public class PayCodesResponse
    {
        [JsonProperty("content")]
        public PaycodeResponse[]? Content { get; set; }

        [JsonProperty("pageable")]
        public Pageable? Pageable { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("sort")]
        public Sort? Sort { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("numberOfElements")]
        public int NumberOfElements { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }
    }

    public class PaycodeResponse
    {
        [JsonProperty("paycode")]
        public string? Paycode { get; set; }

        [JsonProperty("transactionReference")]
        public string? TransactionReference { get; set; }

        [JsonProperty("paycodeReference")]
        public string? PaycodeReference { get; set; }

        [JsonProperty("beneficiaryName")]
        public string? BeneficiaryName { get; set; }

        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("fee")]
        public float Fee { get; set; }

        [JsonProperty("transactionStatus")]
        public string? TransactionStatus { get; set; }

        [JsonProperty("expiryDate")]
        public string? ExpiryDate { get; set; }

        [JsonProperty("createdOn")]
        public DateTime CreatedOn { get; set; }

        [JsonProperty("createdBy")]
        public string? CreatedBy { get; set; }

        [JsonProperty("modifiedBy")]
        public string? ModifiedBy { get; set; }
    }
}