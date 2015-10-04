using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.DefinedModel;
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

        public string GetAssociationEventdata_B()
        {
            IList<GetAssociationEvent_B> objData = BAEModel.GetAssociationEvent_B();

            return Base.ConvertToJson<GetAssociationEvent_B>(objData);
        }

        #endregion Public Methods
    }
}