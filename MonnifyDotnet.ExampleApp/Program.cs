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


    //Initiate one time transaction
    var response = await client.Transaction.InitiateTransaction(transaction);
    if(response.RequestSuccessful)
    {
        Console.WriteLine(response.ResponseBody.CheckoutUrl);
    } else
    {
        Console.WriteLine(response.ResponseMessage);
    }


    //After payment verify payment status
    var transactionStatusResponse = await client.Transaction.GetTransactionStatus(response.ResponseBody.TransactionReference);
    if(transactionStatusResponse.RequestSuccessful)
    {
        Console.WriteLine(transactionStatusResponse.ResponseBody.PaymentStatus);
    }
    else
    {
        Console.WriteLine(transactionStatusResponse.ResponseMessage);
    }
