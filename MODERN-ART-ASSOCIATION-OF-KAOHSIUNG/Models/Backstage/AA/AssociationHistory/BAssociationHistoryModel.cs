using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BAssociationHistoryModel : SharedMethod
    {
        public string GetAssociationHistory()
        {
            string sql = "SELECT AssociationHistory_ID,AssociationHistory_Detail,AssociationHistory_Detail2,AssociationHistory_Detail3,Member_Name,AssociationHistory_Modificationdatetime FROM AssociationHistory LEFT JOIN Member ON AssociationHistory.AssociationHistory_Modifier = Member.Member_ID";
            return ConnectDBToGetData(sql);
        }
    }
}