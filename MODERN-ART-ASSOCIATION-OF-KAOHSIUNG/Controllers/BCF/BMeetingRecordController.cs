using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BCF
{
    public partial class BCFController : Controller
    {
        public IList<MeetingRecord> GetMeetingRecorddata_B()
        {
            return BMTRModel.GetMeetingRecord_B();
        }

        public void CreateMeetingRecorddata_B(MeetingRecord objPara)
        {
            BMTRModel.CreateMeetingRecord_B(objPara);
        }

        public void DeleteMeetingRecorddata_B(MeetingRecord objPara)
        {
            BMTRModel.DeleteMeetingRecord_B(objPara);
        }

        public void UpdateMeetingRecorddata_B(MeetingRecord objPara)
        {
            BMTRModel.UpdateMeetingRecord_B(objPara);
        }
    }
}