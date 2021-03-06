﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CornKillers.Data;
using CornKillers.Models;

namespace CornKillers.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        IUowData db;

        public HomeController(IUowData db)
        {
            this.db = db;
        }

        public HomeController()
        {
            this.db = new UowData();
        }

        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";
            ViewData["PopCorn"] = "Eat all these little bastards";

            //var db = new CornKillersContext();
            //var serial = new Serial();
            //serial.Name = "AppHb";
            //serial.Description = "BigDrama";
            //db.Series.Add(serial);
            //db.SaveChanges();

            var model = this.db.Serials.All().ToList();
            return View(model); 
            //return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
