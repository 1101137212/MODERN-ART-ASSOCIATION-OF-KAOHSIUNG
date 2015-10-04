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
        public IList<PositionRecord> GetPositionRecorddata_B()
        {
            return BPRModel.GetPositionRecord_B();
        }

        public void CreatePositionRecorddata_B(PositionRecord PositionRecord)
        {
            BPRModel.CreatePositionRecord_B(PositionRecord);
        }

        public void DeletePositionRecorddata_B(int PositionRecord_ID)
        {
            BPRModel.DeletePositionRecord_B(PositionRecord_ID);
        }

        public void UpdatePositionRecorddata_B(PositionRecord PositionRecord)
        {
            BPRModel.UpdatePositionRecord_B(PositionRecord);
        }
    }
}