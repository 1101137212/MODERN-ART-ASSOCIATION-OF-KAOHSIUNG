using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;
using System.Data;
using System.Collections.Generic;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BAwardRecordModel : SharedMethod
    {
        public IList<AwardRecord> GetAwardRecord_B()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT ");
            sql.AppendLine("	AwardRecord_ID, ");
            sql.AppendLine("	AwardRecord_Date, ");
            sql.AppendLine("	Award_Title, ");
            sql.AppendLine("	Member_Name ");
            sql.AppendLine("FROM AwardRecord ");
            sql.AppendLine("JOIN Member ");
            sql.AppendLine("	ON AwardRecord.Member_ID = Member.Member_ID ");
            sql.AppendLine("JOIN Award ");
            sql.AppendLine("	ON Award.Award_ID = AwardRecord.Award_ID ");

            DataTable table = ConnectDBToGetData(sql);

            IList<AwardRecord> objData = DataTableToList<AwardRecord>(table);
            return objData;
        }
    }
}