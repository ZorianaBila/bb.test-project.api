using TestProject.Domain;

namespace TestProject.Services
{
    public interface ITransactionService
    {
        Task<List<Transaction>> AddTransaction(Transaction transaction);
    }
}