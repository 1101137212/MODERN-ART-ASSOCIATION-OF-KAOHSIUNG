using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BLN
{
    public partial class BLNController : Controller
    {
        /// <summary>
        /// 後台-最新消息(BLN)
        /// </summary>
        /// <returns></returns>
        /// <history>
        /// 2015/10/04  Turtle    Create
        /// </history>
        #region Private Fields

        private BMediaReportsModel BMDRModel = new BMediaReportsModel();
        private BAwardModel BAWModel = new BAwardModel();
        private BAwardRecordModel BAWRModel = new BAwardRecordModel();
        private BaseController Base = new BaseController();

        #endregion Private Fields

        #region Public Methods

        // 建立學會沿革(BAH)View
        public ActionResult MediaReportsIndex()
        {
            return View();
        }

        // 建立學會沿革(BAH)View
        public ActionResult AwardIndex()
        {
            return View();
        }

        #endregion Public Methods
    }
}