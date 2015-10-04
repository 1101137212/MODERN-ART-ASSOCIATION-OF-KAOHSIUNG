using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.AWS
{
    public partial class AWSController : Controller
    {
        #region Properties

        private ArtisticworksModel AWS = new ArtisticworksModel();
        private BaseController Base = new BaseController();

        #endregion Properties

        #region Public Methods

        // GET: AWS
        public ActionResult Artisticworks()
        {
            return View();
        }

        #endregion Public Methods
    }
}