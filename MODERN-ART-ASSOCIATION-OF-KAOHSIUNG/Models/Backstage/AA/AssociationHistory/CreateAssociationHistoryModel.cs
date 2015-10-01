using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Web.Configuration;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BAssociationHistoryModel : SharedMethod
    {
        public void CreateAssociationHistory_B(AssociationHistory obj)
        {
            StringBuilder sql = new StringBuilder();
            sql = SqlBuilder.Insert(obj);

            List<SqlParameter> parameter = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@AssociationHistory_Detail", Value= obj.AssociationHistory_Detail},
                new SqlParameter() {ParameterName = "@AssociationHistory_Detail2", Value = obj.AssociationHistory_Detail2},
                new SqlParameter() {ParameterName = "@AssociationHistory_Detail3", Value = obj.AssociationHistory_Detail3},
                new SqlParameter() {ParameterName = "@AssociationHistory_Modifier", Value = obj.AssociationHistory_Modifier},
                new SqlParameter() {ParameterName = "@AssociationHistory_Modificationdatetime", Value = obj.AssociationHistory_Modificationdatetime}
            };

            ConnectDBToSendData(sql, parameter);
        }
    }
}