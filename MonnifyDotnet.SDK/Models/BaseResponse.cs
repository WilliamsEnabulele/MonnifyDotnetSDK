using Newtonsoft.Json;

namespace MonnifyDotnet.SDK.Models
{
    public class BaseResponse
    {
        [JsonProperty("requestSuccessful")]
        public bool RequestSuccessful { get; set; }

        [JsonProperty("responseMessage")]
        public string? ResponseMessage { get; set; }

        [JsonProperty("responseCode")]
        public string? ResponseCode { get; set; }
    }

    public class BaseResponse<T>
    {
        [JsonProperty("requestSuccessful")]
        public bool RequestSuccessful { get; set; }

        [JsonProperty("responseMessage")]
        public string? ResponseMessage { get; set; }

        [JsonProperty("responseCode")]
        public string? ResponseCode { get; set; }

        [JsonProperty("responseBody")]
        public T? ResponseBody { get; set; }
    }
}