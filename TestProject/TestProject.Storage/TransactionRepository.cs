using MongoDB.Driver;
using TestProject.Domain;

namespace TestProject.Storage
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly IMongoCollection<Transaction> _transactionCollection;

        public TransactionRepository(IMongoClient client)
        {
            var database = client.GetDatabase(Environment.GetEnvironmentVariable("MONGO_DATABASE_NAME"));
            _transactionCollection = database.GetCollection<Transaction>("transactions");
        }

        public async Task Add(Transaction transaction)
        {
            await _transactionCollection.InsertOneAsync(transaction);
        }

        public async Task<List<Transaction>> GetAll()
        {
            return await _transactionCollection.Find(Builders<Transaction>.Filter.Empty).ToListAsync();
        }
    }
}