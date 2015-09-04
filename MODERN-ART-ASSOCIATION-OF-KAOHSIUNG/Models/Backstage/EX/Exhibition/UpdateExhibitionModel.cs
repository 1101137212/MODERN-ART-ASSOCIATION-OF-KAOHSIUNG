using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BExhibitionModel : SharedMethod
    {
        public void UpdateExhibition_B(Exhibition Exhibition)
        {
            string sql = "UPDATE Exhibition SET Exhibition_Title=@Exhibition_Title,Exhibition_Startdatetime=@Exhibition_Startdatetime,Exhibition_Enddatetime=@Exhibition_Enddatetime,Exhibition_Place=@Exhibition_Place,Exhibition_Detail=@Exhibition_Detail,Exhibition_Picture=@Exhibition_Picture,Exhibition_Otherpeople=@Exhibition_Otherpeople WHERE Exhibition_ID=@Exhibition_ID";
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MAAKDB"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Exhibition_Detail", Exhibition.Exhibition_Detail);
                    cmd.Parameters.AddWithValue("@Exhibition_Enddatetime", Exhibition.Exhibition_Enddatetime);
                    cmd.Parameters.AddWithValue("@Exhibition_ID", Exhibition.Exhibition_ID);
                    cmd.Parameters.AddWithValue("@Exhibition_Otherpeople", Exhibition.Exhibition_Otherpeople);
                    cmd.Parameters.AddWithValue("@Exhibition_Picture", Exhibition.Exhibition_Picture);
                    cmd.Parameters.AddWithValue("@Exhibition_Place", Exhibition.Exhibition_Place);
                    cmd.Parameters.AddWithValue("@Exhibition_Startdatetime", Exhibition.Exhibition_Startdatetime);
                    cmd.Parameters.AddWithValue("@Exhibition_Title", Exhibition.Exhibition_Title);
                    
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