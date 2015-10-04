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
        public void UpdatePositionRecord_B(PositionRecord obj)
        {
            StringBuilder sql = new StringBuilder();
            sql = SqlBuilder.Update(obj);
            List<SqlParameter> parameter = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@Member_ID",Value = obj.Member_ID},
                new SqlParameter() {ParameterName = "@Position_ID",Value = obj.Position_ID},
                new SqlParameter() {ParameterName = "@PositionRecord_Enddate",Value = obj.PositionRecord_Enddate},
                new SqlParameter() {ParameterName = "@PositionRecord_ID",Value = obj.PositionRecord_ID},
                new SqlParameter() {ParameterName = "@PositionRecord_Startdate",Value = obj.PositionRecord_Startdate},
                new SqlParameter() {ParameterName = "@PositionRecord_ID",Value = obj.PositionRecord_ID}
            };
            ConnectDBToSendData(sql, parameter);
              
        }
    }
}