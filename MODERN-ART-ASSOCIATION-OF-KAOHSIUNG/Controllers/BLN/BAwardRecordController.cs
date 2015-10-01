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
        public string GetAwardRecorddata_B()
        {
            return BAWRModel.GetAwardRecord_B();
        }

        public void CreateAwardRecorddata_B(AwardRecord objPara)
        {
            BAWRModel.CreateAwardRecord_B(objPara);
        }

        public void DeleteAwardRecorddata_B(AwardRecord objPara)
        {
            BAWRModel.DeleteAwardRecord_B(objPara);
        }

        public void UpdateAwardRecorddata_B(AwardRecord objPara)
        {
            BAWRModel.UpdateAwardRecord_B(objPara);
        }
    }
}