using TestProject.Domain;
using TestProject.Storage;

namespace TestProject.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public async Task<List<Transaction>> AddTransaction(Transaction transaction)
        {
            await _transactionRepository.Add(transaction);
            return await _transactionRepository.GetAll();
        }
    }
}