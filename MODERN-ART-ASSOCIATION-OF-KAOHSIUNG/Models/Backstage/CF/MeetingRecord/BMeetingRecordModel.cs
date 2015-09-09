using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BMeetingRecordModel : SharedMethod
    {
        public string GetMeetingRecord_B()
        {
            string sql = "SELECT * FROM MeetingRecord";
            return ConnectDBToGetData(sql);
        }
    }
}