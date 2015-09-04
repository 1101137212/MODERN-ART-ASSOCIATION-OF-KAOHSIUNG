using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BMemberModel : SharedMethod
    {
        public string GetMember()
        {
            string sql = "SELECT * FROM Member";
            return ConnectDBToGetData(sql);
        }
    }
}