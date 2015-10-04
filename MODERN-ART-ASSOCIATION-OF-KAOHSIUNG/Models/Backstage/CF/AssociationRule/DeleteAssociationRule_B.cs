using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Web.Configuration;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BAssociationRuleModel : SharedMethod
    {
        public void DeleteAssociationRule_B(AssociationRule obj)
        {
            StringBuilder sql = new StringBuilder();

            sql = SqlBuilder.Delete(obj);

            List<SqlParameter> parameter = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@AssociationRule_ID", Value= obj.AssociationRule_ID}
            };

            ConnectDBToSendData(sql, parameter);
        }
    }
}