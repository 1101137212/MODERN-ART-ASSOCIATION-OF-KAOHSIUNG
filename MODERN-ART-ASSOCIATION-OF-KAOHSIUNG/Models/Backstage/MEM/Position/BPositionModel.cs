using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BPositionModel : SharedMethod
    {
        public string GetPosition_B()
        {
            string sql = "SELECT * FROM Position";
            return ConnectDBToGetData(sql);
        }
    }
}