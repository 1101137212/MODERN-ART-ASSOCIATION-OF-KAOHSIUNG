using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BLN
{
    public partial class BLNController : Controller
    {
        private BMediaReportsModel BMDRModel = new BMediaReportsModel();
        private BAwardModel BAWModel = new BAwardModel();
        private BAwardRecordModel BAWRModel = new BAwardRecordModel();
        // GET: BLN
        public ActionResult MediaReportsIndex()
        {
            return View();
        }
        public ActionResult AwardIndex()
        {
            return View();
        }
    }
}