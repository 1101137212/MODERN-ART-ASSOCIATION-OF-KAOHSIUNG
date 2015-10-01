using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.LN
{
    public class LNController : Controller
    {
        // GET: LN
        public ActionResult Award()
        {
            return View();
        }

        public ActionResult MediaReports()
        {
            return View();
        }

        public ActionResult LatestActivityNews()
        {
            return View();
        }
    }
}