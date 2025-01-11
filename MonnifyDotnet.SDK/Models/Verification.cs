using Newtonsoft.Json;

namespace MonnifyDotnet.SDK.Models
{

    public class ValidateBankAccountResponse
    {
        [JsonProperty("accountNumber")]
        public string? AccountNumber { get; set; }

        [JsonProperty("accountName")]
        public string? AccountName { get; set; }

        [JsonProperty("bankCode")]
        public string? BankCode { get; set; }
    }

    public class BVNInformationVerificationRequest
    {
        [JsonProperty("bvn")]
        public required string BVN { get; set; }

        [JsonProperty("name")]
        public required string Name { get; set; }

        [JsonProperty("dateOfBirth")]
        public required string DateOfBirth { get; set; }

        [JsonProperty("mobileNo")]
        public required string MobileNo { get; set; }
    }

    public class BVNAndAccountNameMatchRequest
    {
        [JsonProperty("bankCode")]
        public required string BankCode { get; set; }

        [JsonProperty("accountNumber")]
        public required string AccountNumber { get; set; }

        [JsonProperty("bvn")]
        public required string BVN { get; set; }
    }

    public class BVNAndAccountNameMatchResponse
    {
        [JsonProperty("bvn")]
        public string? BVN { get; set; }

        [JsonProperty("accountNumber")]
        public string? AccountNumber { get; set; }

        [JsonProperty("accountName")]
        public string? AccountName { get; set; }

        [JsonProperty("matchStatus")]
        public string? MatchStatus { get; set; }

        [JsonProperty("matchPercentage")]
        public int MatchPercentage { get; set; }
    }

    public class NINVerificationRequest
    {
        [JsonProperty("nin")]
        public required string NIN { get; set; }
    }

    public class NINVerificationResponse
    {
        [JsonProperty("nin")]
        public string? NIN { get; set; }

        [JsonProperty("lastName")]
        public string? LastName { get; set; }

        [JsonProperty("firstName")]
        public string? FirstName { get; set; }

        [JsonProperty("middleName")]
        public string? MiddleName { get; set; }

        [JsonProperty("dateOfBirth")]
        public string? DateOfBirth { get; set; }

        [JsonProperty("gender")]
        public string? Gender { get; set; }

        [JsonProperty("mobileNumber")]
        public string? MobileNumber { get; set; }
    }
}