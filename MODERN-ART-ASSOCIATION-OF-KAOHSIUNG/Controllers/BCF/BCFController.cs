using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BCF
{
    public partial class BCFController : Controller
    {
        private BAssociationRuleModel AR = new BAssociationRuleModel();
        private BMeetingRecordModel MTR = new BMeetingRecordModel();
        // GET: BCF
        public ActionResult AssociationRuleIndex()
        {
            return View();
        }

        public ActionResult MeetingRecordIndex()
        {
            return View();
        }
    }
}