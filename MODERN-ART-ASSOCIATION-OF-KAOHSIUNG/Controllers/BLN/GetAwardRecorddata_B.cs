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

        public string GetAwardRecorddata_B()
        {
            IList<AwardRecord> objData = BAWRModel.GetAwardRecord_B();
            return Base.ConvertToJson<AwardRecord>(objData);
        }

        #endregion Public Methods
    }
}