﻿using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
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

        public object DeletePositionRecorddata_B(PositionRecord objPara)
        {
            BPRModel.DeletePositionRecord_B(objPara);
            object objData = true;
            return objData;
        }

        #endregion Public Methods
    }
}