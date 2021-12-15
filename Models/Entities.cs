using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NearMeApp.Models
{
    [BsonIgnoreExtraElements]
    public class Entities
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("user_id")]
        public string UserId { get; set; }
        [BsonElement("category_id")]
        public string CategoryId { get; set; }
        [BsonElement("category_title")]
        public string CategoryTitle { get; set; }
        [BsonElement("location_id")]
        public string LocationId { get; set; }
        [BsonElement("location_title")]
        public string LocationTitle { get; set; }
        [BsonElement("item_tiitle")]
        public string ItemTitle { get; set; }
        [BsonElement("item_subtitle")]
        public string ItemSubtitle { get; set; }
        [BsonElement("opening_time")]
        public string OpenningTime { get; set; }
        [BsonElement("closed_day")]
        public string ClosedDay { get; set; }
        [BsonElement("address")]
        public string Address { get; set; }
        [BsonElement("contacts")]
        public string Contacts { get; set; }
        [BsonElement("services")]
        public string Services { get; set; }
        [BsonElement("details")]
        public string Details { get; set; }
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