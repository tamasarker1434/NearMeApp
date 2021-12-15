using MongoDB.Driver;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NearMeApp.Models
{
    public class DBConnection
    {
        public static IMongoDatabase database = GetMongoClient();
        private static IMongoDatabase GetMongoClient()
        {
            var client = new MongoClient("mongodb+srv://admin_tama112:admin_tama112@cluster0.3up6o.mongodb.net/NearMeApp?retryWrites=true&w=majority");
            var _database = client.GetDatabase("NearMeApp");
            return _database;
        }
    }
}