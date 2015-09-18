using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BAssociationEventModel : SharedMethod
    {
        public void UpdateAssociationEvent_B(AssociationEvent AssociationEvent)
        {
            string sql = "UPDATE AssociationEvent SET AssociationEvent_Title=@AssociationEvent_Title,AssociationEvent_Detail=@AssociationEvent_Detail,AssociationEvent_Date=@AssociationEvent_Date,AssociationEvent_Picture=@AssociationEvent_Picture,AssociationEvent_Modifier=@AssociationEvent_Modifier,AssociationEvent_Modificationdatetime=@AssociationEvent_Modificationdatetime WHERE AssociationEvent_ID=@AssociationEvent_ID";
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
                    cmd.Parameters.AddWithValue("@AssociationEvent_ID", AssociationEvent.AssociationEvent_ID);
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