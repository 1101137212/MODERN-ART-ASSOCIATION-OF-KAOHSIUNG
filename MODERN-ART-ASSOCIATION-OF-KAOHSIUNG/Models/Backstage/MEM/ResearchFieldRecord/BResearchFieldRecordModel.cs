using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BResearchFieldRecordModel : SharedMethod
    {
        public string GetResearchFieldRecord_B()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM ResearchFieldRecord ");
            return ConnectDBToGetData(sql);
        }

        //public string GetResearchFieldRecordByMemberID_B()
        //{
        //    string sql = "SELECT ResearchFieldRecord_ID,ResearchFieldRecord_Date,Member_Name,ResearchField_Name FROM ResearchFieldRecord LEFT JOIN Member ON Member.Member_ID=ResearchFieldRecord.Member_ID LEFT JOIN ResearchField ON ResearchField.ResearchField_ID=ResearchFieldRecord.ResearchField_ID WHERE Member_ID=@Member_ID";
        //    return ConnectDBToGetData(sql);
        //}
    }
}