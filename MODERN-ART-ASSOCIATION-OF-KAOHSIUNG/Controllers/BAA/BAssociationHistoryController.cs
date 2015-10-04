using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BAA
{
    public partial class BAAController : Controller
    {
        public IList<AssociationHistory> GetAssociationHistorydata_B()
        {
            return BAHModel.GetAssociationHistory_B();
        }
        public void CreateAssociationHistorydata_B(AssociationHistory objPara)
        {
            BAHModel.CreateAssociationHistory_B(objPara);
        }
        public void UpdateAssociationHistorydata_B(AssociationHistory objPara)
        {
            BAHModel.UpdateAssociationHistory_B(objPara);
        }
        public void DeleteAssociationHistorydata_B(AssociationHistory objPara)
        {
            BAHModel.DeleteAssociationHistory_B(objPara);
        }
    }
}