using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BResearchFieldRecordModel : SharedMethod
    {
        public void DeleteResearchFieldRecord_B(ResearchFieldRecord obj)
        {
            StringBuilder sql = new StringBuilder();
            sql = SqlBuilder.Delete(obj);
            List<SqlParameter> parameter = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@ResearchFieldRecord_ID",Value = obj.ResearchFieldRecord_ID}
            };
            ConnectDBToSendData(sql, parameter);
        }
    }
}