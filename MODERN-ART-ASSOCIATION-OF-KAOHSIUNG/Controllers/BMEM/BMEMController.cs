using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BMEM
{
    public partial class BMEMController : Controller
    {
        private BMemberModel BMEMModel = new BMemberModel();
        private BPositionModel BPModel = new BPositionModel();
        private BPositionRecordModel BPRModel = new BPositionRecordModel();
        private BResearchFieldModel BRFModel = new BResearchFieldModel();
        private BResearchFieldRecordModel BRFRModel = new BResearchFieldRecordModel();
        
        public ActionResult MemberIndex()
        {
            return View();
        }

    }
}