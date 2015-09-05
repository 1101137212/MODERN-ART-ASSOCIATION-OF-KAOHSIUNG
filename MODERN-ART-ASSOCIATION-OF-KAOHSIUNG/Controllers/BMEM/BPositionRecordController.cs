using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BMEM
{
    public partial class BMEMController : Controller
    {
        public string GetPositionRecorddata_B()
        {
            return PR.GetPositionRecord_B();
        }

        public void CreatePositionRecorddata_B(PositionRecord PositionRecord)
        {
            PR.CreatePositionRecord_B(PositionRecord);
        }

        public void DeletePositionRecorddata_B(int PositionRecord_ID)
        {
            PR.DeletePositionRecord_B(PositionRecord_ID);
        }

        public void UpdatePositionRecorddata_B(PositionRecord PositionRecord)
        {
            PR.UpdatePositionRecord_B(PositionRecord);
        }
    }
}