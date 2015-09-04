using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BExhibitionRecordModel : SharedMethod
    {
        public void CreateExhibitionRecord_B(ExhibitionRecord ExhibitionRecord)
        {
            string sql = "INSERT INTO ExhibitionRecord (ExhibitionRecord_State,Member_ID,Exhibition_ID) VALUES(@ExhibitionRecord_State,@Member_ID,@Exhibition_ID)";
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MAAKDB"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Exhibition_ID", ExhibitionRecord.Exhibition_ID);
                    cmd.Parameters.AddWithValue("@ExhibitionRecord_State", ExhibitionRecord.ExhibitionRecord_State);
                    cmd.Parameters.AddWithValue("@Member_ID", ExhibitionRecord.Member_ID);
                    
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