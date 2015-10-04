using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BCF
{
    public partial class BCFController : Controller
    {
        #region Public Methods

        public IList<MeetingRecord> GetMeetingRecorddata_B()
        {
            return BMTRModel.GetMeetingRecord_B();
        }

        #endregion Public Methods
    }
}