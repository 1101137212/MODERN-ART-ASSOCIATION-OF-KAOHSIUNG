using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BEX
{
    public partial class BEXController : Controller
    {
        #region Public Methods

        public string GetExhibitionRecorddata_B()
        {
            IList<ExhibitionRecord> objData = BEXRModel.GetExhibitionRecord_B();
            return Base.ConvertToJson<ExhibitionRecord>(objData);
        }

        #endregion Public Methods
    }
}