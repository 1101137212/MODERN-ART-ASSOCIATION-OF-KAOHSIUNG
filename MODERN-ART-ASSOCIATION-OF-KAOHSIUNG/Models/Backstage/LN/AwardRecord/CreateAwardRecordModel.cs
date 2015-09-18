using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BAwardRecordModel : SharedMethod
    {
        public void CreateAwardRecord_B(AwardRecord AwardRecord)
        {
            string sql = "INSERT INTO AwardRecord (AwardRecord_Date,Award_ID,Member_ID) VALUES(@AwardRecord_Date,@Award_ID,@Member_ID)";
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MAAKDB"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@AwardRecord_Date", AwardRecord.AwardRecord_Date);
                    cmd.Parameters.AddWithValue("@Award_ID", AwardRecord.Award_ID);
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