using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.EX
{
    public class EXController : Controller
    {
        // GET: EX
        public ActionResult Exhibition()
        {
            return View();
        }

        public ActionResult ExhibitionNews()
        {
            return View();
        }
    }
}