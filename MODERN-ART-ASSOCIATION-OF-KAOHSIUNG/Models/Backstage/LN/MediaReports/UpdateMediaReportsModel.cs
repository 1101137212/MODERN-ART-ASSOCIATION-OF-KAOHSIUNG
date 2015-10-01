using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;
using System.Collections.Generic;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BMediaReportsModel : SharedMethod
    {
        public void UpdateMediaReports_B(MediaReports obj)
        {
            StringBuilder sql = new StringBuilder();

            sql = SqlBuilder.Update(obj);

            List<SqlParameter> parameter = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@MediaReports_Date", Value= obj.MediaReports_Date},
                new SqlParameter() {ParameterName = "@MediaReports_Detail", Value = obj.MediaReports_Detail},
                new SqlParameter() {ParameterName = "@MediaReports_ID", Value = obj.MediaReports_ID},
                new SqlParameter() {ParameterName = "@MediaReports_Modificationdatetime", Value = obj.MediaReports_Modificationdatetime},
                new SqlParameter() {ParameterName = "@MediaReports_Modifier", Value = obj.MediaReports_Modifier},
                new SqlParameter() {ParameterName = "@MediaReports_Picture", Value = obj.MediaReports_Picture},
                new SqlParameter() {ParameterName = "@MediaReports_Title", Value = obj.MediaReports_Title},
            };

            ConnectDBToSendData(sql, parameter);
        }
    }
}