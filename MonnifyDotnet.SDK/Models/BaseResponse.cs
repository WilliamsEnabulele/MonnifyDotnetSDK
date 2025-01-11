using Newtonsoft.Json;

namespace MonnifyDotnet.SDK.Models
{
    public class BaseResponse
    {
        [JsonProperty("requestSuccessful")]
        public bool RequestSuccessful { get; set; }

        [JsonProperty("responseMessage")]
        public required string ResponseMessage { get; set; }
        [JsonProperty("responseCode")]
        public required string ResponseCode { get; set; }
    }


    public class BaseResponse<T>
    {
        [JsonProperty("requestSuccessful")]
        public bool RequestSuccessful { get; set; }

        [JsonProperty("responseMessage")]
        public required string ResponseMessage { get; set; }
        [JsonProperty("responseCode")]
        public required string ResponseCode { get; set; }
        [JsonProperty("responseBody")]
        public required T ResponseBody { get; set; }
    }
}