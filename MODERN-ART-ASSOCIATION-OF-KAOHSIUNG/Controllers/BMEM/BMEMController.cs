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
        private BMemberModel MEM = new BMemberModel();
        private BPositionModel P = new BPositionModel();
        private BPositionRecordModel PR = new BPositionRecordModel();
        
        public ActionResult MemberIndex()
        {
            return View();
        }

    }
}