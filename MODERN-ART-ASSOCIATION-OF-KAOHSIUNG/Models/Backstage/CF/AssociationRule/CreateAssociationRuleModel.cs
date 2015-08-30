using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BAssociationRuleModel : SharedMethod
    {
        public void CreateAssociationRule_B(AssociationRule AssociationRule)
        {
            string sql = "INSERT INTO AssociationRule(AssociationRule_Title,AssociationRule_Detail,AssociationRule_Modifier,AssociationRule_Modificationdatetime) VALUES(@AssociationRule_Title,@AssociationRule_Detail,@AssociationRule_Modifier,@AssociationRule_Modificationdatetime)";
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MAAKDB"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@AssociationRule_Detail", AssociationRule.AssociationRule_Detail);
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