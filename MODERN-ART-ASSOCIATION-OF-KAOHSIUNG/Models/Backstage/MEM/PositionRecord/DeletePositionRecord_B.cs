using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;
using System.Collections.Generic;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BPositionRecordModel : SharedMethod
    {
        public void DeletePositionRecord_B(PositionRecord obj)
        {
           StringBuilder sql = new StringBuilder();
            sql = SqlBuilder.Delete(obj);
            List<SqlParameter> parameter = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@PositionRecord_ID",Value = obj.PositionRecord_ID}
            };
            ConnectDBToSendData(sql, parameter);
                  
        }
    }
}