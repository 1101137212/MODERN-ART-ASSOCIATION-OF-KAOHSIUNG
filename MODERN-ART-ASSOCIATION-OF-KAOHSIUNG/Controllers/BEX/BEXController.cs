using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BEX
{
    public partial class BEXController : Controller
    {
        /// <summary>
        /// 後台-展覽專區(BEX)
        /// </summary>
        /// <returns></returns>
        /// <history>
        /// 2015/10/04  Turtle    Create
        /// </history>
        #region Properties

        private BExhibitionModel BEXModel = new BExhibitionModel();
        private BExhibitionRecordModel BEXRModel = new BExhibitionRecordModel();
        private BaseController Base = new BaseController();

        #endregion Properties

        #region Public Methods

        // 建立展覽專區(BEX)View
        public ActionResult ExhibitionIndex()
        {
            return View();
        }

        #endregion Public Methods
    }
}