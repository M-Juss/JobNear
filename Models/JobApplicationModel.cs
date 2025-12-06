using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace JobNear.Models
{
    public class JobApplicationModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string JobId { get; set; }
        public string SeekerId { get; set; }
        public string CoverLetter { get; set; }
        public List<SupportingDocument> SupportingDocuments { get; set; }
        public string Status { get; set; } = "Pending";
        public bool isSubmissionActive  { get; set; } = true;

        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
