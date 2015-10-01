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
        public string GetMeetingRecorddata_B()
        {
            return BMTRModel.GetMeetingRecord_B();
        }

        public void CreateMeetingRecorddata_B(MeetingRecord MeetingRecord)
        {
            BMTRModel.CreateMeetingRecord_B(MeetingRecord);
        }

        public void DeleteMeetingRecorddata_B(int MeetingRecord_ID)
        {
            BMTRModel.DeleteMeetingRecord_B(MeetingRecord_ID);
        }

        public void UpdateMeetingRecorddata_B(MeetingRecord MeetingRecord)
        {
            BMTRModel.UpdateMeetingRecord_B(MeetingRecord);
        }
    }
}