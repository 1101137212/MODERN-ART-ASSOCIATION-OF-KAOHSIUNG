using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;
using System.Collections.Generic;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BAssociationHistoryModel : SharedMethod
    {
        public void UpdateAssociationHistory_B(AssociationHistory obj)
        {
            StringBuilder sql = new StringBuilder();

            sql = SqlBuilder.Update(obj);

            List<SqlParameter> parameter = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@AssociationHistory_Detail", Value= obj.AssociationHistory_Detail},
                new SqlParameter() {ParameterName = "@AssociationHistory_Modifier", Value = obj.AssociationHistory_Modifier},
                new SqlParameter() {ParameterName = "@AssociationHistory_Modificationdatetime", Value = obj.AssociationHistory_Modificationdatetime},
                new SqlParameter() {ParameterName = "@AssociationHistory_ID", Value = obj.AssociationHistory_ID}
            };

            ConnectDBToSendData(sql, parameter);

        }
    }
}