using TestProject.Domain;

namespace TestProject.Storage
{
    public interface ITransactionRepository
    {
        Task Add(Transaction transaction);

        Task<List<Transaction>> GetAll();
    }
}