using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using CornKillers.Data;
using CornKillers.Models;
using System.Web.Security;

namespace CornKillers.Controllers
{
    public class SerialsController : Controller
    {

        IUowData db;

        public SerialsController(IUowData db)
        {
            this.db = db;
        }

        public SerialsController()
        {
            this.db = new UowData();
        }
        //
        // GET: /SerialsAdministration/

        public ActionResult Index()
        {
            
            return View("Index","Home");
        }

        //
        // GET: /Serials/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Serials/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Serials/Create

        [HttpPost]
        public ActionResult Create(Serial serial)
        {
            try
            {
                // TODO: Add insert logic here
                //if (ModelState.IsValid)
                //{
                //    this.db.Serials.Add(serial);
                //    this.db.SaveChanges();
                //    return RedirectToAction("Index");
                //}

                //ApplicationUser currentUser=new ApplicationUser();
                //currentUser.ApplicationUserID = this.db.Users.All().Where(u=>u.ApplicationUserGUID == (Guid)Membership.GetUser().ProviderUserKey).Select(u=>u.ApplicationUserID).First();
                
                //currentUser = this.db.Users.All().Where(u => u.ApplicationUserGUID.ToString() == Membership.GetUser().ProviderUserKey.ToString()).ToList()[0];
                
                //IEnumerable<ApplicationUser> users = this.db.Users.All();
                //currentUser=users.Where(u => u.ApplicationUserGUID == (Guid)Membership.GetUser().ProviderUserKey)
                //                    .SingleOrDefault();
                var name = Membership.GetUser().UserName;
                var user = (from a in this.db.Users.All()
                            where a.Name == name
                            select a).First();

                //currentUser = user;
                //IQueryable<ApplicationUser> u = from a in users
                //              where a.ApplicationUserGUID == (Guid)Membership.GetUser().ProviderUserKey
                //              select a;

                //currentUser=users.ToList().Find(x => x.ApplicationUserGUID.Equals((Guid)Membership.GetUser().ProviderUserKey));

                serial.ApplicationUsers.Add(user);
                this.db.Serials.Add(serial);
                //this.db.SaveChanges();
                //serial.SerialID = 8;
                this.db.Users.GetById((int)user.ApplicationUserID).Serials.Add(serial);
                this.db.SaveChanges();

                return RedirectToAction("Index","Home");
                //return Redirect("~/Home/Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }
        
        //
        // GET: /SerialsAdministration/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /SerialsAdministration/Edit/5

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

        //
        // GET: /SerialsAdministration/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /SerialsAdministration/Delete/5

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
