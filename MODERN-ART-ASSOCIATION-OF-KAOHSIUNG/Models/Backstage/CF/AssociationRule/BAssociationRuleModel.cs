using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BAssociationRuleModel : SharedMethod
    {
        public string GetAssociationRule_B()
        {
            string sql = "SELECT * FROM AssociationRule";
            return ConnectDBToGetData(sql);
        }
    }
}