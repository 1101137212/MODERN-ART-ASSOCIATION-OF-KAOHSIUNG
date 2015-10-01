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
        public string GetAssociationEventdata_B()
        {
            return BAEModel.GetAssociationEvent_B();
        }
        public void CreateAssociationEventdata_B(AssociationEvent AssociationEvent)
        {
            BAEModel.CreateAssociationEvent_B(AssociationEvent);
        }
        public void DeleteAssociationEventdata_B(int AssociationEvent_ID)
        {
            BAEModel.DeleteAssociationEvent_B(AssociationEvent_ID);
        }
        public void UpdateAssociationEventdata_B(AssociationEvent AssociationEvent)
        {
            BAEModel.UpdateAssociationEvent_B(AssociationEvent);
        }
    }
}