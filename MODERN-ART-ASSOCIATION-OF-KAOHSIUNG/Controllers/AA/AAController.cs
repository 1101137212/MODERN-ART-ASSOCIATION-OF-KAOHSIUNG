using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.AA
{
    public partial class AAController : Controller
    {
        /// <summary>
        /// 前台-關於學會(AA)
        /// </summary>
        /// <returns></returns>
        /// <history>
        /// 2015/10/04  turtle    Create
        /// </history>
        #region Properties

        private AssociationHistoryModel AHModel = new AssociationHistoryModel();
        private AssociationEventModel AEModel = new AssociationEventModel();
        private BaseController Base = new BaseController();

        #endregion Properties

        #region Public Methods

        public ActionResult AssociationApplication()
        {
            return View();
        }

        public ActionResult AssociationEvent()
        {
            return View();
        }

        public ActionResult AssociationHistory()
        {
            return View();
        }

        public ActionResult AssociationOrganization()
        {
            return View();
        }

        #endregion Public Methods
    }
}