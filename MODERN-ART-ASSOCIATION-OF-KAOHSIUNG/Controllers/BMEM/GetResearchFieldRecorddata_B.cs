using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BMEM
{
    public partial class BMEMController : Controller
    {
        #region Public Methods

        public IList<ResearchFieldRecord> GetResearchFieldRecorddata_B()
        {
            return BRFRModel.GetResearchFieldRecord_B();
        }

        #endregion Public Methods
    }
}