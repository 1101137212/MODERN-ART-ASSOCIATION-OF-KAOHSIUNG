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
            return AW.GetAward_B();
        }

        public void CreateAwarddata_B(Award Award)
        {
            AW.CreateAward_B(Award);
        }

        public void DeleteAwarddata_B(int Award_ID)
        {
            AW.DeleteAward_B(Award_ID);
        }

        public void UpdateAwarddata_B(Award Award)
        {
            AW.UpdateAward_B(Award);
        }
    }
}