using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BLN
{
    public partial class BLNController : Controller
    {
        #region Public Methods

        public string GetMediaReportsdata_B()
        {
            IList<MediaReports> objData = BMDRModel.GetMediaReports_B();
            return Base.ConvertToJson<MediaReports>(objData);
        }

        #endregion Public Methods
    }
}