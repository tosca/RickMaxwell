﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RickMaxwell.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BentWood()
        {
            return View();
        }
        public ActionResult WallReliefs()
        {
            return View();
        }

    }
}
