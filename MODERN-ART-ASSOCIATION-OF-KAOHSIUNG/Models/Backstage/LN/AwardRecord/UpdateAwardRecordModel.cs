using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BAwardRecordModel : SharedMethod
    {
        public void UpdateAwardRecord_B(AwardRecord AwardRecord)
        {
            string sql = "UPDATE AwardRecord SET AwardRecord_Date=@AwardRecord_Date,Award_ID=@Award_ID,Member_ID=@Member_ID WHERE AwardRecord_ID=@AwardRecord_ID";
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MAAKDB"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@AwardRecord_Date", AwardRecord.AwardRecord_Date);
                    cmd.Parameters.AddWithValue("@Award_ID", AwardRecord.Award_ID);
                    cmd.Parameters.AddWithValue("@AwardRecord_ID", AwardRecord.AwardRecord_ID);
                    cmd.Parameters.AddWithValue("@Member_ID", AwardRecord.Member_ID);
                    
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