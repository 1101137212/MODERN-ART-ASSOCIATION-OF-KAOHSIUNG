using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;
using System.Collections.Generic;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BAwardModel : SharedMethod
    {
        public void CreateAward_B(Award obj)
        {
            StringBuilder sql = new StringBuilder();
            sql = SqlBuilder.Insert(obj);

            List<SqlParameter> parameter = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@Award_Detail", Value= obj.Award_Detail},
                new SqlParameter() {ParameterName = "@Award_Picture", Value = obj.Award_Picture},
                new SqlParameter() {ParameterName = "@Award_Title", Value = obj.Award_Title}
            };

            ConnectDBToSendData(sql, parameter);
                   
        }
    }
}