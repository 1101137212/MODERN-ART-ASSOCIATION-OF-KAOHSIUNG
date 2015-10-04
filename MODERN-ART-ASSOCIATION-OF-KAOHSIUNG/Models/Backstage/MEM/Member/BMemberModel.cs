using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System;
using System.Data.SqlClient;
using System.Text;
using System.Web.Configuration;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BMemberModel : SharedMethod
    {
        public string GetMember_B()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM Member ");
            return ConnectDBToGetData(sql);
        }
    }
}