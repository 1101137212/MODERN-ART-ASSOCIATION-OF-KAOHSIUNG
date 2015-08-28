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
        public string GetAssociationHistorydata()
        {
            return AH.GetAssociationHistory();
        }
        public void CreateAssociationHistorydata(AssociationHistory AssociationHistory)
        {
            AH.CreateAssociationHistory(AssociationHistory);
        }
        public void UpdateAssociationHistorydata(AssociationHistory AssociationHistory)
        {
            AH.UpdateAssociationHistory(AssociationHistory);
        }
        public void DeleteAssociationHistorydata(int AssociationHistory_ID)
        {
            AH.DeleteAssociationHistory(AssociationHistory_ID);
        }
    }
}