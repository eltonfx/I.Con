using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Igreja.Consolacao.Website.Controllers
{
    public class ContatoController : Controller
    {
        //
        // GET: /Contato/

        public ActionResult Index()
        {
            return View(new Igreja.Consolacao.Website.Models.Banner()
            {
                Title = "Contato",
                Description = "Quisque sed orci ut lacus viverra interdum ornare sed est. Vestibulum pharetra tortor vitae velit pretium rhoncus.",
                Image = Url.Content("~/Images/Igreja02.jpg")
            });
        }
    }
}
