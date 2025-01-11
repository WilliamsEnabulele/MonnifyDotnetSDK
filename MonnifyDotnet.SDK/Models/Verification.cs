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
        public string BVN { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("mobileNo")]
        public string MobileNo { get; set; }

        public BVNInformationVerificationRequest(string bvn, string name, string dateOfBirth, string mobileNo)
        {
            BVN = bvn ?? throw new ArgumentNullException(nameof(bvn));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            DateOfBirth = dateOfBirth ?? throw new ArgumentNullException(nameof(dateOfBirth));
            MobileNo = mobileNo ?? throw new ArgumentNullException(nameof(mobileNo));
        }
    }

    public class BVNAndAccountNameMatchRequest
    {
        [JsonProperty("bankCode")]
        public string BankCode { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("bvn")]
        public string BVN { get; set; }

        public BVNAndAccountNameMatchRequest(string bankCode, string accountNumber, string bvn)
        {
            BankCode = bankCode ?? throw new ArgumentNullException(nameof(bankCode));
            AccountNumber = accountNumber ?? throw new ArgumentNullException(nameof(accountNumber));
            BVN = bvn ?? throw new ArgumentNullException(nameof(bvn));
        }
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
        public string NIN { get; set; }

        public NINVerificationRequest(string nin)
        {
            NIN = nin ?? throw new ArgumentNullException(nameof(nin));
        }
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