﻿using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BAA
{
    public partial class BAAController : Controller
    {
        #region Public Methods

        public string GetAssociationHistorydata_B()
        {
            IList<AssociationHistory> objData = BAHModel.GetAssociationHistory_B();
            return Base.ConvertToJson<AssociationHistory>(objData);
        }

        #endregion Public Methods
    }
}