using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BAwardRecordModel : SharedMethod
    {
        public void DeleteAwardRecord_B(int AwardRecord_ID)
        {
            string sql = "DELETE FROM AwardRecord WHERE AwardRecord_ID=@AwardRecord_ID";
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MAAKDB"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@AwardRecord_ID", AwardRecord_ID);
                    
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        Console.Write("error");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }
    }
}