using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Web.Configuration;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BMemberModel : SharedMethod
    {
        public void DeleteMember_B(Member obj)
        {
            StringBuilder sql = new StringBuilder();
            sql = SqlBuilder.Delete(obj);
            List<SqlParameter> parameter = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@Member_ID",Value = obj.Member_ID}
            };
            ConnectDBToSendData(sql, parameter);
        }
    }
}