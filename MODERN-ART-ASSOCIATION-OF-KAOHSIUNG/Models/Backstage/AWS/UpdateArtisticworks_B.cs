using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;
using System.Collections.Generic;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BArtisticworksModel : SharedMethod
    {
        public void UpdateArtisticworks_B(Artisticworks obj)
        {
            StringBuilder sql = new StringBuilder();

            sql = SqlBuilder.Update(obj);

            List<SqlParameter> parameter = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@Artisticworks_Name", Value= obj.Artisticworks_Name},
                new SqlParameter() {ParameterName = "@Artisticworks_Date", Value = obj.Artisticworks_Date},
                new SqlParameter() {ParameterName = "@Artisticworks_Picture", Value = obj.Artisticworks_Picture},
                new SqlParameter() {ParameterName = "@Member_ID", Value = obj.Member_ID},
                new SqlParameter() {ParameterName = "@Artisticworks_ID", Value = obj.Artisticworks_ID}
            };

            ConnectDBToSendData(sql, parameter);
        }
    }
}