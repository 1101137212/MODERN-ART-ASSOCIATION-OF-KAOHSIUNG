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
        public void CreateAssociationEventdata_B(AssociationEvent objPara)
        {
            BAEModel.CreateAssociationEvent_B(objPara);
        }
        public void DeleteAssociationEventdata_B(AssociationEvent objPara)
        {
            BAEModel.DeleteAssociationEvent_B(objPara);
        }
        public void UpdateAssociationEventdata_B(AssociationEvent objPara)
        {
            BAEModel.UpdateAssociationEvent_B(objPara);
        }
    }
}