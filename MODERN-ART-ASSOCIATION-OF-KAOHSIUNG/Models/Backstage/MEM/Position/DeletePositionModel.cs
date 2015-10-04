using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BPositionModel : SharedMethod
    {
        public void DeletePosition_B(Position obj)
        {
            StringBuilder sql = new StringBuilder();
            sql = SqlBuilder.Delete(obj);
            List<SqlParameter> parameter = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@Position_ID",Value = obj.Position_ID}
            };
            ConnectDBToSendData(sql, parameter);
        }
    }
}