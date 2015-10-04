using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Web.Configuration;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BResearchFieldRecordModel : SharedMethod
    {
        public void CreateResearchFieldRecord_B(ResearchFieldRecord obj)
        {
            StringBuilder sql = new StringBuilder();
            sql = SqlBuilder.Insert(obj);
            List<SqlParameter> parameter = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@ResearchFieldRecord_Date",Value = obj.ResearchFieldRecord_Date},
                new SqlParameter() {ParameterName = "@ResearchField_ID",Value = obj.ResearchField_ID},
                new SqlParameter() {ParameterName = "@Member_ID",Value = obj.Member_ID}
            };
            ConnectDBToSendData(sql, parameter);
        }
    }
}