using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BMediaReportsModel : SharedMethod
    {
        public void CreateMediaReports_B(MediaReports MediaReports)
        {
            string sql = "INSERT INTO MediaReports(MediaReports_Title,MediaReports_Date,MediaReports_Detail,MediaReports_Picture,MediaReports_Modifier,MediaReports_Modificationdatetime) VALUES(@MediaReports_Title,@MediaReports_Date,@MediaReports_Detail,@MediaReports_Picture,@MediaReports_Modifier,@MediaReports_Modificationdatetime)";
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MAAKDB"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MediaReports_Date", MediaReports.MediaReports_Date);
                    cmd.Parameters.AddWithValue("@MediaReports_Detail", MediaReports.MediaReports_Detail);
                    cmd.Parameters.AddWithValue("@MediaReports_Modificationdatetime", MediaReports.MediaReports_Modificationdatetime);
                    cmd.Parameters.AddWithValue("@MediaReports_Modifier", MediaReports.MediaReports_Modifier);
                    cmd.Parameters.AddWithValue("@MediaReports_Picture", MediaReports.MediaReports_Picture);
                    cmd.Parameters.AddWithValue("@MediaReports_Title", MediaReports.MediaReports_Title);
                    
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