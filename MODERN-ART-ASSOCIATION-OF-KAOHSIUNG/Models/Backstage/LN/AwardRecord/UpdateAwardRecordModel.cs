using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Collections.Generic;
using System.Text;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BAwardRecordModel : SharedMethod
    {
        public void UpdateAwardRecord_B(AwardRecord obj)
        {
            StringBuilder sql = new StringBuilder();

            sql = SqlBuilder.Update(obj);

            List<SqlParameter> parameter = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@AwardRecord_Date", Value= obj.AwardRecord_Date},
                new SqlParameter() {ParameterName = "@Award_ID", Value = obj.Award_ID},
                new SqlParameter() {ParameterName = "@AwardRecord_ID", Value = obj.AwardRecord_ID},
                new SqlParameter() {ParameterName = "@Member_ID", Value = obj.Member_ID}
            };

            ConnectDBToSendData(sql, parameter);
        }
    }
}