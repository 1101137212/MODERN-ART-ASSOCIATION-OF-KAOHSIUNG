using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BCF
{
    public partial class BCFController : Controller
    {
        public string GetAssociationRuledata_B()
        {
            return BARModel.GetAssociationRule_B();
        }

        public void CreateAssociationRuledata_B(AssociationRule objPara)
        {
            BARModel.CreateAssociationRule_B(objPara);
        }

        public void DeleteAssociationRuledata_B(AssociationRule objPara)
        {
            BARModel.DeleteAssociationRule_B(objPara);
        }

        public void UpdateAssociationRuledata_B(AssociationRule objPara)
        {
            BARModel.UpdateAssociationRule_B(objPara);
        }
    }
}