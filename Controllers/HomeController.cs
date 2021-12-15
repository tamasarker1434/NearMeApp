using System;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NearMeApp.Controllers;
using NearMeApp.Models;

namespace NearMeApp.Controllers
{
    public class HomeController : Controller
    {
        IMongoDatabase database = DBConnection.database;
        public ActionResult Index()
        {            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}