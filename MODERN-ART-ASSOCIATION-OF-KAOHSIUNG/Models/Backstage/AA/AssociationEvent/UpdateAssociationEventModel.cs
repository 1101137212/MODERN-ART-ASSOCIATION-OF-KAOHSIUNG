using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;
using System.Collections.Generic;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BAssociationEventModel : SharedMethod
    {
        public void UpdateAssociationEvent_B(AssociationEvent obj)
        {
            StringBuilder sql = new StringBuilder();

            sql = SqlBuilder.Update(obj);

            List<SqlParameter> parameter = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@AssociationEvent_Title", Value= obj.AssociationEvent_Title},
                new SqlParameter() {ParameterName = "@AssociationEvent_Detail", Value = obj.AssociationEvent_Detail},
                new SqlParameter() {ParameterName = "@AssociationEvent_Date", Value = obj.AssociationEvent_Date},
                new SqlParameter() {ParameterName = "@AssociationEvent_Picture", Value = obj.AssociationEvent_Picture},
                new SqlParameter() {ParameterName = "@AssociationEvent_Modifier", Value = obj.AssociationEvent_Modifier},
                new SqlParameter() {ParameterName = "@AssociationEvent_Modificationdatetime", Value = obj.AssociationEvent_Modificationdatetime},
                new SqlParameter() {ParameterName = "@AssociationEvent_ID", Value = obj.AssociationEvent_ID}
            };

            ConnectDBToSendData(sql, parameter);
        }
    }
}