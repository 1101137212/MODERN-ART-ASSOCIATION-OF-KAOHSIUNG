using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;
using System.Collections.Generic;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BMeetingRecordModel : SharedMethod
    {
        public void UpdateMeetingRecord_B(MeetingRecord obj)
        {
           StringBuilder sql = new StringBuilder();

            sql = SqlBuilder.Update(obj);

            List<SqlParameter> parameter = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@MeetingRecord_Date", Value= obj.MeetingRecord_Date},
                new SqlParameter() {ParameterName = "@MeetingRecord_Detail", Value = obj.MeetingRecord_Detail},
                new SqlParameter() {ParameterName = "@MeetingRecord_Endtime", Value = obj.MeetingRecord_Endtime},
                new SqlParameter() {ParameterName = "@MeetingRecord_File", Value = obj.MeetingRecord_File},
                new SqlParameter() {ParameterName = "@MeetingRecord_Modificationdatetime", Value = obj.MeetingRecord_Modificationdatetime},
                new SqlParameter() {ParameterName = "@MeetingRecord_Place", Value = obj.MeetingRecord_Place},
                new SqlParameter() {ParameterName = "@MeetingRecord_Starttime", Value = obj.MeetingRecord_Starttime},
                new SqlParameter() {ParameterName = "@MeetingRecord_Title", Value = obj.MeetingRecord_Title},
                new SqlParameter() {ParameterName = "@MeetingRecord_ID", Value = obj.MeetingRecord_ID}
            };

            ConnectDBToSendData(sql, parameter);
        }
    }
}