using Microsoft.AspNetCore.Mvc;
using MonnifyDotnet.SDK.Interfaces;
using MonnifyDotnet.SDK.Models;

namespace ExampleWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MonnifyDotnetSDKTestController : Controller
    {
        private readonly IMonnifyClient _monnifyClient;
        public MonnifyDotnetSDKTestController(IMonnifyClient monnifyClient)
        {
            _monnifyClient = monnifyClient;
        }

        [HttpPost("initiate-transaction")]
        public async Task<IActionResult> InitiateTransaction()
        {
            // Added here for simplicity
            var transaction = new InitiatizeTransaction(10000, "enabulelewilliamss@gmail.com", Guid.NewGuid().ToString(), "NGN", "9438047910")
            {
                CustomerName = "Enabulele Williams"
            };
            var response = await _monnifyClient.Transaction.InitiateTransaction(transaction);
            return Ok(response);
        }


        [HttpGet("get-transaction-statu/{transactionReference}")]
        public async Task<IActionResult> GetTransactionStatus([FromRoute] string transactionReference)
        {
            var response = await _monnifyClient.Transaction.GetTransactionStatus(transactionReference);
            return Ok(response);
        }
    }
}
