using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers
{
    public partial class BAWSController : Controller
    {
        /// <summary>
        /// 後台-作品集(BAWS)
        /// </summary>
        /// <returns></returns>
        /// <history>
        /// 2015/10/04  Turtle    Create
        /// </history>
        ///

        #region Properties

        private BArtisticworksModel BAWSModel = new BArtisticworksModel();
        private BaseController Base = new BaseController();

        #endregion Properties

        #region Public Methods

        // 建立作品集(BAWS)View

        public ActionResult ArtisticworksIndex()
        {
            return View();
        }

        #endregion Public Methods
    }
}