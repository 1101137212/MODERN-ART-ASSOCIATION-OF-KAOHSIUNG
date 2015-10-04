using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BCF
{
    public partial class BCFController : Controller
    {
        /// <summary>
        /// 後台-會務專區(BCF)
        /// </summary>
        /// <returns></returns>
        /// <history>
        /// 2015/10/04  Turtle    Create
        /// </history>

        #region Properties

        private BAssociationRuleModel BARModel = new BAssociationRuleModel();
        private BMeetingRecordModel BMTRModel = new BMeetingRecordModel();
        private BaseController Base = new BaseController();

        #endregion Properties

        #region Public Methods

        // 建立學會規章(AR)View
        public ActionResult AssociationRuleIndex()
        {
            return View();
        }

        // 建立會議記錄(MTR)View
        public ActionResult MeetingRecordIndex()
        {
            return View();
        }

        #endregion Public Methods
    }
}