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
        public string GetAssociationEventdata()
        {
            return AE.GetAssociationEvent();
        }
        public void CreateAssociationEventdata(AssociationEvent AssociationEvent)
        {
            AE.CreateAssociationEvent(AssociationEvent);
        }
        public void DeleteAssociationEventdata(int AssociationEvent_ID)
        {
            AE.DeleteAssociationEvent(AssociationEvent_ID);
        }
        public void UpdateAssociationEventdata(AssociationEvent AssociationEvent)
        {
            AE.UpdateAssociationEvent(AssociationEvent);
        }
    }
}