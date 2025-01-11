// See https://aka.ms/new-console-template for more information
using MonnifyDotnet.SDK.Implementations;
using MonnifyDotnet.SDK.Models;

var options = new MonnifyOptions
{
    ApiKey = "MK_TEST_5F5JLAUZKV",
    ApiSecret = "5470BV5JC8SXNB6N0V1ZMDK7BBAS6G0H",
    BaseUrl = "https://sandbox.monnify.com"
};
var client = new MonnifyClient(options);
var transaction = new InitiatizeTransaction(100, "enabulelewilliams@gmail.com", Guid.NewGuid().ToString(), "NGN", "9438047910");
transaction.CustomerName = "Enabulele Williams";

try
{
    var response = await client.Transaction.InitiateTransaction(transaction);
    Console.WriteLine(response);
} catch(Exception ex)
{
    Console.WriteLine(ex.ToString());
}
