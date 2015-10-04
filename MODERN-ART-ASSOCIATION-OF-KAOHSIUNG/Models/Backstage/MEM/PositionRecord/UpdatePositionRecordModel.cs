using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;
using System.Collections.Generic;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BPositionRecordModel : SharedMethod
    {
        public void UpdatePositionRecord_B(PositionRecord PositionRecord)
        {
            string sql = "UPDATE PositionRecord SET PositionRecord_Startdate=@PositionRecord_Startdate,PositionRecord_Enddate=@PositionRecord_Enddate,Member_ID=@Member_ID,Position_ID=@Position_ID,MeetingRecord_ID=@MeetingRecord_ID WHERE PositionRecord_ID=@PositionRecord_ID";
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MAAKDB"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Member_ID", PositionRecord.Member_ID);
                    cmd.Parameters.AddWithValue("@Position_ID", PositionRecord.Position_ID);
                    cmd.Parameters.AddWithValue("@PositionRecord_Enddate", PositionRecord.PositionRecord_Enddate);
                    cmd.Parameters.AddWithValue("@PositionRecord_ID", PositionRecord.PositionRecord_ID);
                    cmd.Parameters.AddWithValue("@PositionRecord_Startdate", PositionRecord.PositionRecord_Startdate);
                    cmd.Parameters.AddWithValue("@PositionRecord_ID", PositionRecord.PositionRecord_ID);

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