using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BAA
{
    public partial class BAAController : Controller
    {
        private BAssociationHistoryModel AH = new BAssociationHistoryModel();
        // GET: BAA
        public ActionResult AssociationHistoryIndex()
        {
            return View();
        }
        
        public ActionResult AssociationEventIndex()
        {
            return View();
        }
    }
}