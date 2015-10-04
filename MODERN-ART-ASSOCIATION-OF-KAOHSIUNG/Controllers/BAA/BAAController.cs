using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage;
using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BAA
{
    public partial class BAAController : Controller
    {
        /// <summary>
        /// 後台-關於學會(BAA)
        /// </summary>
        /// <returns></returns>
        /// <history>
        /// 2015/10/04  Turtle    Create
        /// </history>

        #region Properties

        private BAssociationHistoryModel BAHModel = new BAssociationHistoryModel();
        private BAssociationEventModel BAEModel = new BAssociationEventModel();
        private BaseController Base = new BaseController();

        #endregion Properties

        #region Public Methods

        // 建立學會沿革(BAH)View
        public ActionResult AssociationHistoryIndex()
        {
            return View();
        }

        // 建立學會大事跡(BAH)View
        public ActionResult AssociationEventIndex()
        {
            return View();
        }

        // 建立學會沿革(BAH)View
        public ActionResult AssociationOrganizationIndex()
        {
            return View();
        }

        #endregion Public Methods
    }
}