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

        public object UpdatePositiondata_B(Position objPara)
        {
            BPModel.UpdatePosition_B(objPara);
            object objData = true;
            return objData;
        }

        #endregion Public Methods
    }
}