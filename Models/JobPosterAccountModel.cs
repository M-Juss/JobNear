using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNear.Models
{
    public class JobPosterAccountModel
    {
        [BsonId] 
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
