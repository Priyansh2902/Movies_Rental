﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRentalV04.Controllers
{
    public class RentalsController : Controller
    {
        // GET: NewRentals
        public ActionResult New()
        {
            return View();
        }
    }
}