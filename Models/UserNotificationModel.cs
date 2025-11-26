using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace JobNear.Models
{
    public class UserNotificationModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string NotificationId { get; set; }
        public string Key { get; set; }
        public string HeaderMessage { get; set; }
        public string Remarks { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public bool IsRead { get; set; } = false;
        public byte? WarningCount { get; set; }
    }
}
