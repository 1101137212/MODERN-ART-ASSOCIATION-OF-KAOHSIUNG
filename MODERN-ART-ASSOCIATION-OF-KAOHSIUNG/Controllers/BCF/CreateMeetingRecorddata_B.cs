﻿using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BCF
{
    public partial class BCFController : Controller
    {
        #region Public Methods

        public object CreateMeetingRecorddata_B(MeetingRecord objPara)
        {
            BMTRModel.CreateMeetingRecord_B(objPara);
            object objData = true;
            return objData;
        }

        #endregion Public Methods
    }
}