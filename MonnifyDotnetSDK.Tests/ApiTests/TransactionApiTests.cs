using FluentAssertions;
using MonnifyDotnet.SDK.Models;
using MonnifyDotnetSDK.Tests.Configuration;
using MonnifyDotnetSDK.Tests.TestFixtures;

namespace MonnifyDotnetSDK.Tests.ApiTests
{
    public class TransactionApiTests : TestBaseFixture
    {

        [Fact]
        public async Task InitiateTransaction_Should_Return_Successful_Response()
        {
            // Arrange
            var request = new InitiatizeTransaction(1000, "email@gmail.com", Guid.NewGuid().ToString(), "NGN", TestSettings.ContractCode)
            {
                CustomerName = "Williams Enabulele",
            };


            // Act
            var response = await monnifyClient.Transaction.InitiateTransaction(request);

            // Assert

            response.ResponseBody.Should().NotBeNull();
            response.ResponseBody.TransactionReference.Should().NotBeNullOrEmpty();
            response.ResponseBody.CheckoutUrl.Should().NotBeNullOrEmpty();
        }
    }
}