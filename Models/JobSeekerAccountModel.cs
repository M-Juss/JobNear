using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace JobNear.Models
{
    public class JobSeekerAccountModel
    {
        [BsonId] //serves as a  primary key
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Username { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Sex { get; set; }
        public DateTime Birthdate { get; set; } = DateTime.Now;
        public short Age { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public byte[] ProfilePicture { get; set; }
        public List<SupportingDocument> SupportingDocuments { get; set; }
        public Boolean IsDraft { get; set; } = true;
        public string Status { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;

    }
    public class SupportingDocument {
        public string FileName { get; set; }
        public byte[] FileContent { get; set; }
    }
}
