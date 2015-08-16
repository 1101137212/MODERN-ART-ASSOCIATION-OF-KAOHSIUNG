using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models
{
    public class Member : SharedMethod
    {
        public string GetMember()
        {
            //SqlConnection conn = new SqlConnection(@"Server=(LocalDB)\v11.0;DataBase=MAAK;Trusted_Connection=True;");
            //string sql = "SELECT * FROM Member";
            //DataSet db = new DataSet();
            //using (conn)
            //{
            //    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            //    adapter.Fill(db, "Member");
            //}
            //EnumerableRowCollection<DataRow> table = db.Tables[0].AsEnumerable();
            //return table;
            string sql = "SELECT * FROM Member";
            return ConnectDBToGetData(sql);
        }
    }
}