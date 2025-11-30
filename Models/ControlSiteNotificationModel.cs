using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace JobNear.Models
{
    public class ControlSiteNotificationModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string MaintenanceTitle { get; set; }
        public string MaintenanceDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
