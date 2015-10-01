using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Collections.Generic;
using System.Text;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BAwardModel : SharedMethod
    {
        public void UpdateAward_B(Award obj)
        {
            StringBuilder sql = new StringBuilder();

            sql = SqlBuilder.Update(obj);

            List<SqlParameter> parameter = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@Award_Detail", Value= obj.Award_Detail},
                new SqlParameter() {ParameterName = "@Award_ID", Value = obj.Award_ID},
                new SqlParameter() {ParameterName = "@Award_Picture", Value = obj.Award_Picture},
                new SqlParameter() {ParameterName = "@Award_Title", Value = obj.Award_Title}
            };

            ConnectDBToSendData(sql, parameter);
        }
    }
}