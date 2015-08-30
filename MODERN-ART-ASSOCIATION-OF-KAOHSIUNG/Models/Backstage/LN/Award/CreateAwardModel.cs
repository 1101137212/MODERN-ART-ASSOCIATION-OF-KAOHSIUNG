using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BAwardModel : SharedMethod
    {
        public void CreateAward_B(Award Award)
        {
            string sql = "INSERT INTO Award (Award_Title,Award_Detail,Award_Picture) VALUES(@Award_Title,@Award_Detail,@Award_Picture)";
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MAAKDB"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Award_Detail", Award.Award_Detail);
                    cmd.Parameters.AddWithValue("@Award_Picture", Award.Award_Picture);
                    cmd.Parameters.AddWithValue("@Award_Title", Award.Award_Title);
                    
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