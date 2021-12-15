using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NearMeApp.Models
{
    [BsonIgnoreExtraElements]
    public class Feedback
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("user_id")]
        public string UserId { get; set; }
        [BsonElement("item_id")]
        public string ItemId { get; set; }
        [BsonElement("comment")]
        public string Comment { get; set; }
        [BsonElement("ratting")]
        public string Ratting { get; set; }
        [BsonElement("comment_date")]
        public string CommentDate { get; set; }
    }
}