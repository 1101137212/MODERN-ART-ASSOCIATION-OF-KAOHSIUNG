using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BAwardModel : SharedMethod
    {
        public string GetAward_B()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM Award ");

            return ConnectDBToGetData(sql);
        }
    }
}