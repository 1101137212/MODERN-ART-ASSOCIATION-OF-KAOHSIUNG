using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BAssociationHistoryModel : SharedMethod
    {
        public void UpdateAssociationHistory_B(AssociationHistory AssociationHistory)
        {
            string sql = "UPDATE AssociationHistory SET AssociationHistory_Detail=@AssociationHistory_Detail,AssociationHistory_Detail2=@AssociationHistory_Detail2,AssociationHistory_Detail3=@AssociationHistory_Detail3,AssociationHistory_Modifier=@AssociationHistory_Modifier,AssociationHistory_Modificationdatetime=@AssociationHistory_Modificationdatetime WHERE AssociationHistory_ID=@AssociationHistory_ID";
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MAAKDB"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@AssociationHistory_Detail", AssociationHistory.AssociationHistory_Detail);
                    cmd.Parameters.AddWithValue("@AssociationHistory_Detail2", AssociationHistory.AssociationHistory_Detail2);
                    cmd.Parameters.AddWithValue("@AssociationHistory_Detail3", AssociationHistory.AssociationHistory_Detail3);
                    cmd.Parameters.AddWithValue("@AssociationHistory_Modifier", AssociationHistory.AssociationHistory_Modifier);
                    cmd.Parameters.AddWithValue("@AssociationHistory_Modificationdatetime", AssociationHistory.AssociationHistory_Modificationdatetime);
                    cmd.Parameters.AddWithValue("@AssociationHistory_ID", AssociationHistory.AssociationHistory_ID);
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