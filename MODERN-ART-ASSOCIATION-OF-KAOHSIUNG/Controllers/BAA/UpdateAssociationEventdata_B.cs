using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BAA
{
    public partial class BAAController : Controller
    {
        #region Public Methods

        public object UpdateAssociationEventdata_B(AssociationEvent objPara)
        {
            BAEModel.UpdateAssociationEvent_B(objPara);
            object objData = true;
            return objData;
        }

        #endregion Public Methods
    }
}