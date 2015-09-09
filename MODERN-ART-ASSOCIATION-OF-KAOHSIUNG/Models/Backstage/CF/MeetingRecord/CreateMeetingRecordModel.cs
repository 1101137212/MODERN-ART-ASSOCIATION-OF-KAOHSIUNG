using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BMeetingRecordModel : SharedMethod
    {
        public void CreateMeetingRecord_B(MeetingRecord MeetingRecord)
        {
            string sql = "INSERT INTO MeetingRecord(MeetingRecord_Title,MeetingRecord_Detail,MeetingRecord_Date,MeetingRecord_Starttime,MeetingRecord_Endtime,MeetingRecord_Place,MeetingRecord_File,MeetingRecord_Modificationdatetime) VALUES(@MeetingRecord_Title,@MeetingRecord_Detail,@MeetingRecord_Date,@MeetingRecord_Starttime,@MeetingRecord_Endtime,@MeetingRecord_Place,@MeetingRecord_File,@MeetingRecord_Modificationdatetime)";
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MAAKDB"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MeetingRecord_Date", MeetingRecord.MeetingRecord_Date);
                    cmd.Parameters.AddWithValue("@MeetingRecord_Detail", MeetingRecord.MeetingRecord_Detail);
                    cmd.Parameters.AddWithValue("@MeetingRecord_Endtime", MeetingRecord.MeetingRecord_Endtime);
                    cmd.Parameters.AddWithValue("@MeetingRecord_File", MeetingRecord.MeetingRecord_File);
                    cmd.Parameters.AddWithValue("@MeetingRecord_Modificationdatetime", MeetingRecord.MeetingRecord_Modificationdatetime);
                    cmd.Parameters.AddWithValue("@MeetingRecord_Place", MeetingRecord.MeetingRecord_Place);
                    cmd.Parameters.AddWithValue("@MeetingRecord_Starttime", MeetingRecord.MeetingRecord_Starttime);
                    cmd.Parameters.AddWithValue("@MeetingRecord_Title", MeetingRecord.MeetingRecord_Title);
                    
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