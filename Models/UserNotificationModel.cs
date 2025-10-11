using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace JobNear.Models
{
    public class UserNotificationModel
    {
        [BsonId] 
        [BsonRepresentation(BsonType.ObjectId)]
        string Id { get; set; }
        string Key { get; set; }
        string HeaderMessage { get; set; }
        string Remarks { get; set; }
        string Type { get; set; }
        DateTime Date{ get; set; }
    }
}
