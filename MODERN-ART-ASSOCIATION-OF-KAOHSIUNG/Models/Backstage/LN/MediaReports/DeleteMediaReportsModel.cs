using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;
using System.Collections.Generic;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BMediaReportsModel : SharedMethod
    {
        public void DeleteMediaReports_B(MediaReports obj)
        {
            StringBuilder sql = new StringBuilder();

            sql = SqlBuilder.Delete(obj);

            List<SqlParameter> parameter = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@MediaReports_ID", Value= obj.MediaReports_ID}
            };

            ConnectDBToSendData(sql, parameter);
        }
    }
}