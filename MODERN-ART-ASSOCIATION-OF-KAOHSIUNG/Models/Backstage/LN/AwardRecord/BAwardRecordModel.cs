using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BAwardRecordModel : SharedMethod
    {
        public string GetAwardRecord_B()
        {
            string sql = "SELECT AwardRecord_ID,AwardRecord_Date,Award_Title,Member_Name FROM AwardRecord JOIN Member ON AwardRecord.Member_ID=Member.Member_ID JOIN Award ON Award.Award_ID=AwardRecord.Award_ID";
            return ConnectDBToGetData(sql);
        }
    }
}