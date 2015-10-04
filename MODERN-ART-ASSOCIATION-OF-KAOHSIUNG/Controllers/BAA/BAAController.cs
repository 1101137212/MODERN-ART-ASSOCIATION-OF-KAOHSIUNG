using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BAA
{   
    public partial class BAAController : Controller
    {
        private BAssociationHistoryModel BAHModel = new BAssociationHistoryModel();
        private BAssociationEventModel BAEModel = new BAssociationEventModel();
        private BaseController Base = new BaseController();
        // GET: BAA
        public ActionResult AssociationHistoryIndex()
        {
            return View();
        }

        public ActionResult AssociationEventIndex()
        {
            return View();
        }
        public ActionResult AssociationOrganizationIndex()
        {
            return View();
        }
    }
}