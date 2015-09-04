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
            return AWR.GetAwardRecord_B();
        }

        public void CreateAwardRecorddata_B(AwardRecord AwardRecord)
        {
            AWR.CreateAwardRecord_B(AwardRecord);
        }

        public void DeleteAwardRecorddata_B(int AwardRecord_ID)
        {
            AWR.DeleteAwardRecord_B(AwardRecord_ID);
        }

        public void UpdateAwardRecorddata_B(AwardRecord AwardRecord)
        {
            AWR.UpdateAwardRecord_B(AwardRecord);
        }
    }
}