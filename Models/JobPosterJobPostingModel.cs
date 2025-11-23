using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNear.Models
{
    public class JobPosterJobPostingModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string BusinessId { get; set; } // this will link to JobPosterBusinessModel Id
        public string JobAddress { get; set; }
        public string JobPosition { get; set; }
        public string JobEmploymentType { get; set; }
        public string JobWorkModel { get; set; }
        public string JobMinimumQualification { get; set; }
        public string JobPreferredQualification { get; set; }
        public string JobAbout { get; set; }
        public string JobResponsibilities { get; set; }
        public string JobPaymentType { get; set; }
        public double JobMonthlyRate { get; set; }
        public double JobHourlyRate { get; set; }
        public string JobStatus { get; set; }
        public bool IsBusinessOnReview { get; set; } = true;
    }
}
