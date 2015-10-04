using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.AA
{
    public partial class AAController : Controller
    {
        #region Public Methods

        public string GetAssociationHistoryListData()
        {
            IList<AssociationHistory> objAssociationHistorydata = AHModel.GetAssociationHistoryListData();
            return Base.ConvertToJson<AssociationHistory>(objAssociationHistorydata);
        }

        #endregion Public Methods
    }
}