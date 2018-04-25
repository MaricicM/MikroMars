using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nas_Sajtic.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Galerija()
        {
            return View();
        }

        public ActionResult Ponuda ()
        {
            return View();
        }
        public PartialViewResult _Ponuda1 ()
        {
            return PartialView();
        }
        public PartialViewResult _Ponuda2()
        {
            return PartialView();
        }
        public PartialViewResult _Ponuda3()
        {
            return PartialView();
        }

        public ActionResult ONama ()
        {
            return View();
        }

        public ActionResult Kontakt ()
        {
            return View();
        }

        public ActionResult RadoviUToku ()
        {
            return View();
        }
    }
}