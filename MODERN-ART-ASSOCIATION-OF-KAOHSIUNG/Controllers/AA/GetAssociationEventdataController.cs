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

        public string GetAssociationEventListData()
        {
            IList<AssociationEvent> objAssociationEventdata = AEModel.GetAssociationEventListData();
            return Base.ConvertToJson<AssociationEvent>(objAssociationEventdata);
        }

        #endregion Public Methods
    }
}