using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace JobNear.Models
{
    public class ControlSiteMaintenanceModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public bool IsUnderMaintenance { get; set; } = false;
    }
}
