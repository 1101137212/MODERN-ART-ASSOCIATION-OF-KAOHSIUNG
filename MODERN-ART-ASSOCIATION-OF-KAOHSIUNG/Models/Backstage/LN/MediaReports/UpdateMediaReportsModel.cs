using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BMediaReportsModel : SharedMethod
    {
        public void UpdateMediaReports_B(MediaReports MediaReports)
        {
            string sql = "UPDATE MediaReports SET MediaReports_Title=@MediaReports_Title,MediaReports_Date=@MediaReports_Date,MediaReports_Detail=@MediaReports_Detail,MediaReports_Picture=@MediaReports_Picture,MediaReports_Modifier=@MediaReports_Modifier,MediaReports_Modificationdatetime=@MediaReports_Modificationdatetime WHERE MediaReports_ID=@MediaReports_ID";
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MAAKDB"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MediaReports_Date", MediaReports.MediaReports_Date);
                    cmd.Parameters.AddWithValue("@MediaReports_Detail", MediaReports.MediaReports_Detail);
                    cmd.Parameters.AddWithValue("@MediaReports_ID", MediaReports.MediaReports_ID);
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