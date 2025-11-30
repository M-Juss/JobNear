using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace JobNear.Models
{
    public class AdminAccountModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }

    }
}
