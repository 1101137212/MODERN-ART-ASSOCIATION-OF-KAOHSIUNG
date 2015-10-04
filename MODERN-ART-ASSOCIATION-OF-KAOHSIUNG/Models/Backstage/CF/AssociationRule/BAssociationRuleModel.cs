using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;
using System.Collections.Generic;
using System.Data;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BAssociationRuleModel : SharedMethod
    {
        public IList<AssociationRule> GetAssociationRule_B()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM AssociationRule ");
            DataTable table = ConnectDBToGetData(sql);

            IList<AssociationRule> objData = DataTableToList<AssociationRule>(table);
            return objData;

        }
    }
}