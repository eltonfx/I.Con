﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Igreja.Consolacao.Website.Controllers
{
    public class PastoraisController : Controller
    {
        //
        // GET: /Pastorais/

        public ActionResult Index()
        {
            return View(new Igreja.Consolacao.Website.Models.Banner()
            {
                Title = "Pastorais",
                Description = "Quisque sed orci ut lacus viverra interdum ornare sed est. Vestibulum pharetra tortor vitae velit pretium rhoncus.",
                Image = Url.Content("~/Images/Igreja02.jpg")
            });
        }
    }
}
