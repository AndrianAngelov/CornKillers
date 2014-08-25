using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CornKillers.Data;
using CornKillers.Models;

namespace CornKillers.Controllers
{
    public class SerialsAdministrationController : Controller
    {

        IUowData db;

        public SerialsAdministrationController(IUowData db)
        {
            this.db = db;
        }

        public SerialsAdministrationController()
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
        // GET: /SerialsAdministration/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /SerialsAdministration/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /SerialsAdministration/Create

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
                this.db.Serials.Add(serial);
                this.db.SaveChanges();

                //return RedirectToAction("Index");
                return Redirect("~/Home/Index");
            }
            catch
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
