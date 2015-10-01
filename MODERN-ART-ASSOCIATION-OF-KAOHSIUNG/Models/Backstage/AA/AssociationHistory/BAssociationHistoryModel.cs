using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BAssociationHistoryModel : SharedMethod
    {
        public string GetAssociationHistory_B()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT ");
            sql.AppendLine("	AssociationHistory_ID, ");
            sql.AppendLine("	AssociationHistory_Detail, ");
            sql.AppendLine("	AssociationHistory_Detail2, ");
            sql.AppendLine("	AssociationHistory_Detail3, ");
            sql.AppendLine("	Member_Name, ");
            sql.AppendLine("	AssociationHistory_Modificationdatetime ");
            sql.AppendLine("FROM AssociationHistory ");
            sql.AppendLine("LEFT JOIN Member ");
            sql.AppendLine("	ON AssociationHistory.AssociationHistory_Modifier = Member.Member_ID ");
            return ConnectDBToGetData(sql);

        }
    }
}