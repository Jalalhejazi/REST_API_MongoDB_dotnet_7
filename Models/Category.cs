using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongoDotnetDemo.Models
{
    public class Category
    {
        [BsonId]
        public string Id { get; set; }
        public string? CategoryName { get; set; }
    }
}
