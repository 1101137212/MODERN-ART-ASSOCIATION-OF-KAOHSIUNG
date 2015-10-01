using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;
using System.Collections.Generic;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BExhibitionModel : SharedMethod
    {
        public void CreateExhibition_B(Exhibition obj)
        {
            StringBuilder sql = new StringBuilder();
            sql = SqlBuilder.Insert(obj);

            List<SqlParameter> parameter = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@Exhibition_Detail", Value= obj.Exhibition_Detail},
                new SqlParameter() {ParameterName = "@Exhibition_Enddatetime", Value = obj.Exhibition_Enddatetime},
                new SqlParameter() {ParameterName = "@Exhibition_Otherpeople", Value = obj.Exhibition_Otherpeople},
                new SqlParameter() {ParameterName = "@Exhibition_Picture", Value = obj.Exhibition_Picture},
                new SqlParameter() {ParameterName = "@Exhibition_Place", Value = obj.Exhibition_Place},
                new SqlParameter() {ParameterName = "@Exhibition_Startdatetime", Value = obj.Exhibition_Startdatetime},
                new SqlParameter() {ParameterName = "@Exhibition_Title", Value = obj.Exhibition_Title}
            };

            ConnectDBToSendData(sql, parameter);
        }
    }
}