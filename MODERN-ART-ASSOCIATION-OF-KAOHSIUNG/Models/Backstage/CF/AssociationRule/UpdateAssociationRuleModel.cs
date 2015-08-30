using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BAssociationRuleModel : SharedMethod
    {
        public void UpdateAssociationRule_B(AssociationRule AssociationRule)
        {
            string sql = "UPDATE AssociationRule SET AssociationRule_Title=@AssociationRule_Title,AssociationRule_Detail=@AssociationRule_Detail,AssociationRule_Modifier=@AssociationRule_Modifier,AssociationRule_Modificationdatetime=@AssociationRule_Modificationdatetime WHERE AssociationRule_ID=@AssociationRule_ID";
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MAAKDB"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@AssociationRule_Detail", AssociationRule.AssociationRule_Detail);
                    cmd.Parameters.AddWithValue("@AssociationRule_ID", AssociationRule.AssociationRule_ID);
                    cmd.Parameters.AddWithValue("@AssociationRule_Modificationdatetime", AssociationRule.AssociationRule_Modificationdatetime);
                    cmd.Parameters.AddWithValue("@AssociationRule_Modifier", AssociationRule.AssociationRule_Modifier);
                    cmd.Parameters.AddWithValue("@AssociationRule_Title", AssociationRule.AssociationRule_Title);
                    
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