using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nas_Sajtic.Controllers
{
    public class PonudaController : Controller
    {
        public ActionResult Ponuda()
        {
            return View();
        }

        public ActionResult SpecPonudaMini()
        {
            return View();
        }
        public PartialViewResult _Ponuda1()
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
    }
}