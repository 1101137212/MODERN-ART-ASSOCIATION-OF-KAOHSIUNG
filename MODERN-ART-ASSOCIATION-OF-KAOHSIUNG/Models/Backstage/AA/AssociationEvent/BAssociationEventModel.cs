using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.DefinedModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.Configuration;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BAssociationEventModel : SharedMethod
    {
        public IList<GetAssociationEvent_B> GetAssociationEvent_B()
        {
            StringBuilder sql = new StringBuilder();
            
            sql.AppendLine("SELECT ");
            sql.AppendLine("	AssociationEvent_ID, ");
            sql.AppendLine("	AssociationEvent_Title, ");
            sql.AppendLine("	AssociationEvent_Detail, ");
            sql.AppendLine("	AssociationEvent_Date, ");
            sql.AppendLine("	AssociationEvent_Picture, ");
            sql.AppendLine("	Member_Name, ");
            sql.AppendLine("	AssociationEvent_Modificationdatetime ");
            sql.AppendLine("FROM AssociationEvent ");
            sql.AppendLine("LEFT JOIN Member ");
            sql.AppendLine("	ON AssociationEvent.AssociationEvent_Modifier = Member.Member_ID ");
            
            DataTable table = ConnectDBToGetData(sql);
           
            return DataTableToList<GetAssociationEvent_B>(table);
        }
    }
}