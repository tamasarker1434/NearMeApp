using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NearMeApp.Models
{
    [BsonIgnoreExtraElements]
    public class Categories
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("category_title")]
        public string CategoryTitle { get; set; }
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