using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Web;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Web.Script;
using System.Web.Script.Serialization;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models
{
    public class Artisticworksdata : SharedMethod
    {
        public string GetArtisticworks()
        {
            string sql = "SELECT Artisticworks_Name,Artisticworks_Date,Artisticworks_Picture,Member_Name FROM Artisticworks LEFT JOIN Member ON Artisticworks.Member_ID = Member.Member_ID";
            return ConnectDBToGetData(sql);
        }

        //public string GetArtisticworks()
        //{
        //    DataTable dt = new DataTable();
        //    using (SqlConnection conn = new SqlConnection(@"Server=(LocalDB)\v11.0;DataBase=MAAK;Trusted_Connection=True;"))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("SELECT Artisticworks_Name,Artisticworks_Date,Artisticworks_Picture,Member_Name FROM Artisticworks LEFT JOIN Member ON Artisticworks.Member_ID = Member.Member_ID", conn))
        //        {
        //            //conn.Open();
        //            SqlDataAdapter da = new SqlDataAdapter(cmd);
        //            da.Fill(dt);
        //            JavaScriptSerializer serializer = new JavaScriptSerializer();
        //            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
        //            Dictionary<string, object> row;
        //            foreach (DataRow dr in dt.Rows)
        //            {
        //                row = new Dictionary<string, object>();
        //                foreach (DataColumn col in dt.Columns)
        //                {
        //                    row.Add(col.ColumnName, dr[col]);
        //                }
        //                rows.Add(row);
        //            }
        //            //conn.Close();
        //            return serializer.Serialize(rows);

        //        }
        //    }
        //}

        //public static List<Artisticworks> GetArtisticworks()
        //{
        //List<Artisticworks> Artisticworks = new List<Artisticworks>();
        //SqlConnection conn = new SqlConnection(@"Server=(LocalDB)\v11.0;DataBase=MAAK;Trusted_Connection=True;");
        //SqlCommand cmd = new SqlCommand("SELECT Artisticworks_Name,Artisticworks_Date,Artisticworks_Picture,Member_Name FROM Artisticworks LEFT JOIN Member ON Artisticworks.Member_ID = Member.Member_ID", conn);
        //conn.Open();
        //SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        //while (reader.Read())
        //{
        //    Artisticworks Artisticwork = new Artisticworks()
        //    {
        //        Artisticworks_ID = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Artisticworks_ID"))),
        //        Artisticworks_Name = reader.GetValue(reader.GetOrdinal("Artisticworks_Name")).ToString(),
        //        Artisticworks_Date = (reader.IsDBNull(reader.GetOrdinal("Artisticworks_Date"))) ? new Nullable<DateTime>() : Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("Artisticworks_Date"))),
        //        Artisticworks_Picture = reader.GetValue(reader.GetOrdinal("Artisticworks_Picture")).ToString(),
        //    };
        //    yield return Artisticwork;
        //}
        //reader.Close();

        //List<Artisticworks> Artisticworks = new List<Artisticworks>();
        //SqlConnection conn = new SqlConnection(@"Server=(LocalDB)\v11.0;DataBase=MAAK;Trusted_Connection=True;");
        //SqlCommand cmd = new SqlCommand("SELECT Artisticworks_Name,Artisticworks_Date,Artisticworks_Picture,Member_Name FROM Artisticworks LEFT JOIN Member ON Artisticworks.Member_ID = Member.Member_ID", conn);
        //conn.Open();
        //SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        //while (reader.Read())
        //{
        //    Artisticworks Artisticwork = new Artisticworks();
        //    for (int row = 0; row < reader.FieldCount; row++)
        //    {
        //        PropertyInfo property = Artisticwork.GetType().GetProperty(reader.GetName(row));
        //        property.SetValue(Artisticwork, (reader.IsDBNull(row)) ? "[NULL]" : reader.GetValue(row), null);
        //    }
        //    Artisticworks.Add(Artisticwork);
        //}
        //reader.Close();
        //return Artisticworks;


        //using (SqlConnection conn = new SqlConnection(@"Server=(LocalDB)\v11.0;DataBase=MAAK;Trusted_Connection=True;"))
        //{
        //    string sql = "SELECT Artisticworks_Name,Artisticworks_Date,Artisticworks_Picture,Member_Name FROM Artisticworks LEFT JOIN Member ON Artisticworks.Member_ID = Member.Member_ID";
        //    using (SqlCommand cmd = new SqlCommand(sql, conn))
        //    {
        //        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
        //        {
        //            DataSet ds = new DataSet();
        //            da.Fill(ds, "Artisticworks");
        //            //List<Artisticworks> Artisticworksdata = ds.Tables[0].DefaultView;
        //            return ds;
        //        }
        //    }
        //}



        //DataSet db = new DataSet();
        //using (conn)
        //{
        //    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
        //    adapter.Fill(db, "Artisticworks");
        //}
        //List<Artisticworks> table = db.Tables[0].DefaultView()
        //return table;

        //public EnumerableRowCollection<DataRow> GetArtisticworks()
        //{
        //    SqlConnection conn = new SqlConnection(@"Server=(LocalDB)\v11.0;DataBase=MAAK;Trusted_Connection=True;");
        //    string sql = "SELECT Artisticworks_Name,Artisticworks_Date,Artisticworks_Picture,Member_Name FROM Artisticworks LEFT JOIN Member ON Artisticworks.Member_ID = Member.Member_ID";
        //    DataSet db = new DataSet();
        //    using (conn)
        //    {
        //        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
        //        adapter.Fill(db, "Artisticworks");
        //    }
        //    string aaa = db.Tables
        //    EnumerableRowCollection<DataRow> table = db.Tables[0].AsEnumerable();
        //    //List<Artisticworks> Artisticworks = new List<Artisticworks>;
        //    return table;
        //}
        //public static List<Artisticworks> GetArtisticworks()
        //{
        //    List<Artisticworks> Artisticworks = new List<Artisticworks>;
        //    SqlConnection conn = new SqlConnection(@"Server=(LocalDB)\v11.0;DataBase=MAAK;Trusted_Connection=True;");
        //    string sql = "SELECT Artisticworks_Name,Artisticworks_Date,Artisticworks_Picture,Member_Name FROM Artisticworks LEFT JOIN Member ON Artisticworks.Member_ID = Member.Member_ID";
        //    DataSet db = new DataSet();
        //    using (conn)
        //    {
        //        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
        //        adapter.Fill(db, "Artisticworks");
        //    }
        //    Artisticworks.Add(db.Tables[0]);
        //    return table;
        //}

        //List<Artisticworks> Artisticworks = new List<Artisticworks>;
        //    using(SqlConnection conn = new SqlConnection(@"Server=(LocalDB)\v11.0;DataBase=MAAK;Trusted_Connection=True;"))
        //    {
        //        string sql = "SELECT Artisticworks_Name,Artisticworks_Date,Artisticworks_Picture,Member_Name FROM Artisticworks LEFT JOIN Member ON Artisticworks.Member_ID = Member.Member_ID";
        //        using(SqlCommand cmd = new SqlCommand(sql,conn))
        //        {
        //            using(SqlDataAdapter da = new SqlDataAdapter(cmd))
        //            {
        //                DataSet ds = new DataSet();
        //                da.Fill(ds,"Artisticworks");
        //                //List<Artisticworks> Artisticworksdata = ds.Tables[0].DefaultView;
        //                return ds;
        //            }
        //        }
        //    }


    }
    
        
    
}