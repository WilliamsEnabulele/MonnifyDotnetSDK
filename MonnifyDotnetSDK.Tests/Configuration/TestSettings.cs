namespace MonnifyDotnetSDK.Tests.Configuration
{
    public class TestSettings
    {
        public static string ApiKey => Environment.GetEnvironmentVariable("MONNIFY_API_KEY") ?? throw new ArgumentNullException(nameof(ApiKey));

        public static string ApiSecret => Environment.GetEnvironmentVariable("MONNIFY_API_SECRET") ?? throw new ArgumentNullException(nameof(ApiSecret));

        public static string BaseUrl => Environment.GetEnvironmentVariable("MONNIFY_BASE_URL") ?? throw new ArgumentNullException(nameof(BaseUrl));

        public static string ContractCode => Environment.GetEnvironmentVariable("MONNIFY_CONTRACT_CODE") ?? throw new ArgumentNullException(nameof(ContractCode));
    }
}