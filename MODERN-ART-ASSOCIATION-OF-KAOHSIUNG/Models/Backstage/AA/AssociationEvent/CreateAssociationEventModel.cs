using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BAssociationEventModel : SharedMethod
    {
        public void CreateAssociationEvent_B(AssociationEvent AssociationEvent)
        {
            string sql = "INSERT INTO AssociationEvent(AssociationEvent_Title,AssociationEvent_Detail,AssociationEvent_Date,AssociationEvent_Picture,AssociationEvent_Modifier,AssociationEvent_Modificationdatetime) VALUES(@AssociationEvent_Title,@AssociationEvent_Detail,@AssociationEvent_Date,@AssociationEvent_Picture,@AssociationEvent_Modifier,@AssociationEvent_Modificationdatetime)";
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MAAKDB"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@AssociationEvent_Title", AssociationEvent.AssociationEvent_Title);
                    cmd.Parameters.AddWithValue("@AssociationEvent_Detail", AssociationEvent.AssociationEvent_Detail);
                    cmd.Parameters.AddWithValue("@AssociationEvent_Date", AssociationEvent.AssociationEvent_Date);
                    cmd.Parameters.AddWithValue("@AssociationEvent_Picture", AssociationEvent.AssociationEvent_Picture);
                    cmd.Parameters.AddWithValue("@AssociationEvent_Modifier", AssociationEvent.AssociationEvent_Modifier);
                    cmd.Parameters.AddWithValue("@AssociationEvent_Modificationdatetime", AssociationEvent.AssociationEvent_Modificationdatetime);
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