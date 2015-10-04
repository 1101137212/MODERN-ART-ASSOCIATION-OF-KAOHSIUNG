using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BResearchFieldRecordModel : SharedMethod
    {
        public void UpdateResearchFieldRecord_B(ResearchFieldRecord obj)
        {
            StringBuilder sql = new StringBuilder();
            sql = SqlBuilder.Update(obj);
            List<SqlParameter> parameter = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@ResearchField_ID",Value = obj.ResearchField_ID},
                new SqlParameter() {ParameterName = "@ResearchFieldRecord_Date",Value = obj.ResearchFieldRecord_Date},
                new SqlParameter() {ParameterName = "@ResearchFieldRecord_ID",Value = obj.ResearchFieldRecord_ID},
                new SqlParameter() {ParameterName = "@Member_ID",Value = obj.Member_ID}
            };
            ConnectDBToSendData(sql, parameter);
        }
    }
}