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
            return AR.GetAssociationRule_B();
        }

        public void CreateAssociationRuledata_B(AssociationRule AssociationRule)
        {
            AR.CreateAssociationRule_B(AssociationRule);
        }

        public void DeleteAssociationRuledata_B(int AssociationRule_ID)
        {
            AR.DeleteAssociationRule_B(AssociationRule_ID);
        }

        public void UpdateAssociationRuledata_B(AssociationRule AssociationRule)
        {
            AR.UpdateAssociationRule_B(AssociationRule);
        }
    }
}