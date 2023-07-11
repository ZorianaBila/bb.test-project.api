using Microsoft.AspNetCore.Mvc;
using TestProject.Domain;
using TestProject.Services;

namespace TestProject.Web.Controllers
{
    [ApiController]
    [Route("api/transactions")]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpPost]
        public async Task<ActionResult<List<Transaction>>> AddTransaction(Transaction transaction)
        {
            var transactions = await _transactionService.AddTransaction(transaction);
            return Ok(transactions);
        }
    }
}