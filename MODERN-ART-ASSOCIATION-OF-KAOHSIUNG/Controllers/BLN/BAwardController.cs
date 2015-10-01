using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BLN
{
    public partial class BLNController : Controller
    {
        public string GetAwarddata_B()
        {
            return BAWModel.GetAward_B();
        }

        public void CreateAwarddata_B(Award objPara)
        {
            BAWModel.CreateAward_B(objPara);
        }

        public void DeleteAwarddata_B(Award objPara)
        {
            BAWModel.DeleteAward_B(objPara);
        }

        public void UpdateAwarddata_B(Award objPara)
        {
            BAWModel.UpdateAward_B(objPara);
        }
    }
}