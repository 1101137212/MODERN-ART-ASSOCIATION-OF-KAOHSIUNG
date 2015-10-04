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

        public object CreateExhibitionRecorddata_B(ExhibitionRecord objPara)
        {
            BEXRModel.CreateExhibitionRecord_B(objPara);
            object objData = true;
            return objData;
        }

        #endregion Public Methods
    }
}