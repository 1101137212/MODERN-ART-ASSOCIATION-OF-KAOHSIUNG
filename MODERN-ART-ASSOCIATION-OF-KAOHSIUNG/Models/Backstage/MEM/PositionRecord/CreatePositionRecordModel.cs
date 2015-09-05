using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BPositionRecordModel : SharedMethod
    {
        public void CreatePositionRecord_B(PositionRecord PositionRecord)
        {
            string sql = "INSERT INTO PositionRecord (PositionRecord_Startdate,PositionRecord_Enddate,Member_ID,Position_ID,MeetingRecord_ID) VALUES(@PositionRecord_Startdate,@PositionRecord_Enddate,@Member_ID,@Position_ID,@MeetingRecord_ID)";
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MAAKDB"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Member_ID", PositionRecord.Member_ID);
                    cmd.Parameters.AddWithValue("@Position_ID", PositionRecord.Position_ID);
                    cmd.Parameters.AddWithValue("@PositionRecord_Enddate", PositionRecord.PositionRecord_Enddate);
                    cmd.Parameters.AddWithValue("@MeetingRecord_ID", PositionRecord.MeetingRecord_ID);
                    cmd.Parameters.AddWithValue("@PositionRecord_Startdate", PositionRecord.PositionRecord_Startdate);
                    
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