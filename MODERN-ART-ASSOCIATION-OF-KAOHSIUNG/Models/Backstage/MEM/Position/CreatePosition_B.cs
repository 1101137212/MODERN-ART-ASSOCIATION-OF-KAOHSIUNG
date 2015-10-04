using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Web.Configuration;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BPositionModel : SharedMethod
    {
        public void CreatePosition_B(Position obj)
        {
            StringBuilder sql = new StringBuilder();
            sql = SqlBuilder.Insert(obj);
            List<SqlParameter> parameter = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@Position_Competence",Value = obj.Position_Competence},
                new SqlParameter() {ParameterName = "@Position_Name",Value = obj.Position_Name}
            };
            ConnectDBToSendData(sql, parameter);
        }
    }
}