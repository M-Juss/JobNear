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

        public string JobPosition { get; set; }
        public string JobType { get; set; }
        public string JobDescription { get; set; }
        public string JobQualification { get; set; }
        public string JobSalary { get; set; }
    }
}
