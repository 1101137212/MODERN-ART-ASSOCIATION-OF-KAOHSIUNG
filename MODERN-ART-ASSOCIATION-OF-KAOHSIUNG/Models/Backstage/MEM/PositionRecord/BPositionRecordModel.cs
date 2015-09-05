using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BPositionRecordModel : SharedMethod
    {
        public string GetPositionRecord_B()
        {
            string sql = "SELECT * FROM PositionRecord";
            return ConnectDBToGetData(sql);
        }
    }
}