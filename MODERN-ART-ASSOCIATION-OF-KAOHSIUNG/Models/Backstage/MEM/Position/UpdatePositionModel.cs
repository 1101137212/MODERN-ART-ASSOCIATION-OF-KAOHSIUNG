using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BPositionModel : SharedMethod
    {
        public void UpdatePosition_B(Position Position)
        {
            string sql = "UPDATE Position SET Position_Name=@Position_Name,Position_Competence=@Position_Competence WHERE Position_ID=@Position_ID";
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MAAKDB"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Position_Competence", Position.Position_Competence);
                    cmd.Parameters.AddWithValue("@Position_ID", Position.Position_ID);
                    cmd.Parameters.AddWithValue("@Position_Name", Position.Position_Name);
                    
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