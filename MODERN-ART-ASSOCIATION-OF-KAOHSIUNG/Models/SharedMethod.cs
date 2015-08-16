using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Script.Serialization;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models
{
    public class SharedMethod
    {
        public static string ConnectDBToGetData(string sql)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(@"Server=(LocalDB)\v11.0;DataBase=MAAK;Trusted_Connection=True;"))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    return ConvertToJson(DataTableToList(dt));
                }
            }
        }

        public static string ConvertToJson(List<Dictionary<string, object>> dataList)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Serialize(dataList);
        }

        public static List<Dictionary<string, object>> DataTableToList(DataTable dataTableList)
        {
            List<Dictionary<string, object>> listReturn = new List<Dictionary<string, object>>();
            foreach (DataRow row in dataTableList.Rows)
            {
                Dictionary<string, object> dataRow = new Dictionary<string, object>();
                foreach (DataColumn col in dataTableList.Columns)
                {
                    dataRow.Add(col.ColumnName, row[col]);
                }
                listReturn.Add(dataRow);
            }
            return listReturn;
        }
    }
}