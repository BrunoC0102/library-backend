using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Library.Entities
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public string Author { get; set; }

        public bool Available { get; set; }

        public int QuantityAvailable { get; set; }
    }
}
