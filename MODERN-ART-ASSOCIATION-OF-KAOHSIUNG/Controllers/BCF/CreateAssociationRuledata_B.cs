using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
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

        public void CreateAssociationRuledata_B(AssociationRule objPara)
        {
            BARModel.CreateAssociationRule_B(objPara);
        }

        #endregion Public Methods
    }
}