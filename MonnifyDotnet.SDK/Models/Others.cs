using Newtonsoft.Json;

namespace MonnifyDotnet.SDK.Models
{
    public class BankResponse
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("code")]
        public string? Code { get; set; }

        [JsonProperty("ussd_template")]
        public object? UssdTemplate { get; set; }

        [JsonProperty("base_ussd_code")]
        public object? BaseUssdCode { get; set; }

        [JsonProperty("transfer_ussd_template")]
        public object? TransferUssdTemplate { get; set; }
    }
}