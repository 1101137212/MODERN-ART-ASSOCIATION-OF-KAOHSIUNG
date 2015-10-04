using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;
using System.Collections.Generic;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BExhibitionRecordModel : SharedMethod
    {
        public void CreateExhibitionRecord_B(ExhibitionRecord obj)
        {
            StringBuilder sql = new StringBuilder();
            sql = SqlBuilder.Insert(obj);

            List<SqlParameter> parameter = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@Exhibition_ID", Value= obj.Exhibition_ID},
                new SqlParameter() {ParameterName = "@ExhibitionRecord_State", Value = obj.ExhibitionRecord_State},
                new SqlParameter() {ParameterName = "@Member_ID", Value = obj.Member_ID}
            };

            ConnectDBToSendData(sql, parameter);
        }  
    }
}