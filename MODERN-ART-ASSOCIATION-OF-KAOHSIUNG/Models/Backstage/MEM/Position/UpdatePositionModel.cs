using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BPositionModel : SharedMethod
    {
        public void UpdatePosition_B(Position obj)
        {
            StringBuilder sql = new StringBuilder();
            sql = SqlBuilder.Update(obj);
            List<SqlParameter> parameter = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@Position_ID",Value = obj.Position_ID},
                new SqlParameter() {ParameterName = "@Position_Name",Value = obj.Position_Name},
                new SqlParameter() {ParameterName = "@Position_Competence",Value = obj.Position_Competence}
            };
            ConnectDBToSendData(sql, parameter);
        }
    }
}