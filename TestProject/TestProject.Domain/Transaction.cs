using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace TestProject.Domain
{
    public class Transaction
    {
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        public string Id { get; set; }

        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Hash { get; set; }

        public DateTime SentAt { get; set; } = DateTime.Now;
    }
}