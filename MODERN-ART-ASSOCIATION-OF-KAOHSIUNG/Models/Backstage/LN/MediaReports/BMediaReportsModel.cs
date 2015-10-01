using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BMediaReportsModel : SharedMethod
    {
        public string GetMediaReports_B()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM MediaReports ");
            return ConnectDBToGetData(sql);
        }
    }
}