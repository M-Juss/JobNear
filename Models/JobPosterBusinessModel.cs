using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNear.Models
{
    public class JobPosterBusinessModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string BusinessName { get; set; }
        public string BusinessAddress { get; set; }
        public string BusinessContact { get; set; }
        public string BusinessEmail { get; set; }
        public byte[] BusinessLogo { get; set; }
        public string BusinessDescription { get; set; }
        public string BusinessIndustry { get; set; }
        public string BusinessSite { get; set; }
        public string BusinessDocument { get; set; }
        public bool IsVerified { get; set; } = false;
    }
}
