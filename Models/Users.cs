using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NearMeApp.Models
{
    [BsonIgnoreExtraElements]
    public class Users
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("user_id")]
        public string UserId { get; set; }
        [BsonElement("password")]
        public string Password { get; set; }
        [BsonElement("is_admin")]
        public string IsAdmin { get; set; }
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