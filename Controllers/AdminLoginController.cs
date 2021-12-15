using MongoDB.Driver;
using NearMeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NearMeApp.Controllers
{
    public class AdminLoginController : Controller
    {
        //Database connection
        IMongoDatabase database = DBConnection.database;
        // GET: AdminLogin
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdminLogin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminLogin/LoginAdmin
        public ActionResult LoginAdmin()
        {
            return View();
        }

        // POST: AdminLogin/LoginAdmin
        [HttpPost]
        public ActionResult LoginAdmin(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                string userId = collection["username"];
                string pass = collection["passwword"];
                if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(pass))
                {
                    ModelState.AddModelError("", "Please Give Proper User Id and Password!!");
                    return View();
                }
                else
                {
                    var data = database.GetCollection<Users>(DBHelperClass.UserCollectionName);
                    var userMaching = data.Find(x => x.UserId == userId && x.Password == pass && x.IsDeleted == false).FirstOrDefault();
                    if (userMaching != null)
                    {                        
                        Session["USER_ID"] = userMaching.Id;
                        Session["USER_NAME"] = userMaching.Name;
                        ModelState.AddModelError("", "Success!!!");
                        return RedirectToAction("Index", "AdminPanel");
                    }
                    else
                    {
                        ModelState.AddModelError("", "User Id and Password is Invalid!!!");
                        return View();
                    }
                }                
            }
            catch
            {
                return View("LoginAdmin");
            }
        }
        // GET: AdminLogin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminLogin/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminLogin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminLogin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminLogin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminLogin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
