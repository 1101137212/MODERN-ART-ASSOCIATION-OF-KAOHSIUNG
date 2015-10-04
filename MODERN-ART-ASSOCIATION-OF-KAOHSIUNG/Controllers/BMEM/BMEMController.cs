using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BMEM
{
    public partial class BMEMController : Controller
    {
        /// <summary>
        /// 後台-會員簡介(BMEM)
        /// </summary>
        /// <returns></returns>
        /// <history>
        /// 2015/10/04  Turtle    Create
        /// </history>
        #region Properties

        private BMemberModel BMEMModel = new BMemberModel();
        private BPositionModel BPModel = new BPositionModel();
        private BPositionRecordModel BPRModel = new BPositionRecordModel();
        private BResearchFieldModel BRFModel = new BResearchFieldModel();
        private BResearchFieldRecordModel BRFRModel = new BResearchFieldRecordModel();
        private BaseController Base = new BaseController();

        #endregion Private Fields

        #region Public Methods

        // 建立會員簡介(BMEM)View
        public ActionResult MemberIndex()
        {
            return View();
        }

        #endregion Public Methods
    }
}