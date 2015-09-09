using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BResearchFieldRecordModel : SharedMethod
    {
        public void UpdateResearchFieldRecord_B(ResearchFieldRecord ResearchFieldRecord)
        {
            string sql = "UPDATE ResearchFieldRecord SET ResearchFieldRecord_Date=@ResearchFieldRecord_Date,Member_ID=@Member_ID,ResearchField_ID=@ResearchField_ID WHERE ResearchFieldRecord_ID=@ResearchFieldRecord_ID";
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MAAKDB"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ResearchFieldRecord_ID", ResearchFieldRecord.ResearchFieldRecord_ID);
                    cmd.Parameters.AddWithValue("@Member_ID", ResearchFieldRecord.Member_ID);
                    cmd.Parameters.AddWithValue("@ResearchField_ID", ResearchFieldRecord.ResearchField_ID);
                    cmd.Parameters.AddWithValue("@ResearchFieldRecord_Date", ResearchFieldRecord.ResearchFieldRecord_Date);
                    
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