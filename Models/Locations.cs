using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NearMeApp.Models
{
    [BsonIgnoreExtraElements]
    public class Locations
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("location_title")]
        public string LocationTitle { get; set; }
        [BsonElement("upzilla")]
        public string Upzilla { get; set; }
        [BsonElement("district")]
        public string District { get; set; }
        [BsonElement("is_deleted")]
        public bool IsDeleted { get; set; }
        [BsonElement("created_on")]
        public string CreatedOn { get; set; }
        [BsonElement("updated_on")]
        public string UpdatedOn { get; set; }
        [BsonElement("deleted_on")]
        public string DeletedOn { get; set; }
    }
}