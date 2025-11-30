using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace JobNear.Models
{
    public class JobPosterAccountModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
