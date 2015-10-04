using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Collections.Generic;
using System.Text;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BMeetingRecordModel : SharedMethod
    {
        public void CreateMeetingRecord_B(MeetingRecord obj)
        {
            StringBuilder sql = new StringBuilder();
            sql = SqlBuilder.Insert(obj);

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
            };

            ConnectDBToSendData(sql, parameter);
        }
    }
}