using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
namespace JobNear.Models
{
    public class RepostBusinessModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Complainant { get; set; }
        public string Complainee { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public List<SupportingDocument> SupportingDocuments { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
