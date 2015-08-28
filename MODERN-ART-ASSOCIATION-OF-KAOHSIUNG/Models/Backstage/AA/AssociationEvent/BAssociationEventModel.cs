using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BAssociationEventModel : SharedMethod
    {
        public string GetAssociationEvent()
        {
            string sql = "SELECT AssociationEvent_ID,AssociationEvent_Title,AssociationEvent_Detail,AssociationEvent_Date,AssociationEvent_Picture,Member_Name,AssociationEvent_Modificationdatetime FROM AssociationEvent LEFT JOIN Member ON AssociationEvent.AssociationEvent_Modifier=Member.Member_ID";
            return ConnectDBToGetData(sql);
        }
    }
}