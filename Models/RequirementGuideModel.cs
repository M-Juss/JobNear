using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace JobNear.Models
{
    public class RequirementGuideModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string DocumentName { get; set; }
        public string DocumentDescription { get; set; }
        public string RequirementType { get; set; }
        public string UserType { get; set; }
        public List<SupportingDocument> SupportingDocuments { get; set; }
    }
}
