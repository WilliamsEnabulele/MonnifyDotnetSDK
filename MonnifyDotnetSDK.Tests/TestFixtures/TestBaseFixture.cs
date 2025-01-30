using MonnifyDotnet.SDK;
using MonnifyDotnet.SDK.Models;
using MonnifyDotnetSDK.Tests.Configuration;

namespace MonnifyDotnetSDK.Tests.TestFixtures
{
    public class TestBaseFixture
    {
        protected readonly IMonnifyClient monnifyClient;

        public TestBaseFixture()
        {
            monnifyClient = new MonnifyClient(new MonnifyOptions
            {
                ApiKey = TestSettings.ApiKey,
                ApiSecret = TestSettings.ApiSecret,
                BaseUrl = TestSettings.BaseUrl,
                ContractCode = TestSettings.ContractCode,
            });
        }
    }
}