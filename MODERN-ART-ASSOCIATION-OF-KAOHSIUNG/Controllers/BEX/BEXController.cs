using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BEX
{
    public partial class BEXController : Controller
    {
        private BExhibitionModel BEXModel = new BExhibitionModel();
        private BExhibitionRecordModel BEXRModel = new BExhibitionRecordModel();
        // GET: BEX
        public ActionResult ExhibitionIndex()
        {
            return View();
        }
    }
}