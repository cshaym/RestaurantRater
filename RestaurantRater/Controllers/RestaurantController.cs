﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantRater.Controllers
{   // Whatever you name the controller is what will show on the url
    public class RestaurantController : Controller
    {
        // GET: Restaurant/Index
        public ActionResult Index()
        {
            return View();
        }
    }
}