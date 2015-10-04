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

        public object CreateAwarddata_B(Award objPara)
        {
            BAWModel.CreateAward_B(objPara);
            object objData = true;
            return objData;
        }

        #endregion Public Methods
    }
}