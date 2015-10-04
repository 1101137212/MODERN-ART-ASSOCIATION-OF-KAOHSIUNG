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
        public void CreateAssociationRule_B(AssociationRule obj)
        {
            StringBuilder sql = new StringBuilder();
            sql = SqlBuilder.Insert(obj);

            List<SqlParameter> parameter = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@AssociationRule_Detail", Value= obj.AssociationRule_Detail},
                new SqlParameter() {ParameterName = "@AssociationRule_Modificationdatetime", Value = obj.AssociationRule_Modificationdatetime},
                new SqlParameter() {ParameterName = "@AssociationRule_Modifier", Value = obj.AssociationRule_Modifier},
                new SqlParameter() {ParameterName = "@AssociationRule_Title", Value = obj.AssociationRule_Title}
            };

            ConnectDBToSendData(sql, parameter);
        }
    }
}