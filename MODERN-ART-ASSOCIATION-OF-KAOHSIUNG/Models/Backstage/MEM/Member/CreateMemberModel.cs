using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BMemberModel : SharedMethod
    {
        public void CreateMember_B(Member Member)
        {
            string sql = "INSERT INTO Member(Member_Name,Member_Mobile,Member_Addresszip,Member_Address,Member_Picture,Member_Email,Member_NowPosition,Member_Account,Member_Password,Member_Education,Member_Experience,Member_Adminname,Member_Adminpasswd) VALUES(@Member_Name,@Member_Mobile,@Member_Addresszip,@Member_Address,@Member_Picture,@Member_Email,@Member_NowPosition,@Member_Account,@Member_Password,@Member_Education,@Member_Experience,@Member_Adminname,@Member_Adminpasswd)";
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MAAKDB"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Member_Account", Member.Member_Account);
                    cmd.Parameters.AddWithValue("@Member_Address", Member.Member_Address);
                    cmd.Parameters.AddWithValue("@Member_Addresszip", Member.Member_Addresszip);
                    cmd.Parameters.AddWithValue("@Member_Adminname", Member.Member_Adminname);
                    cmd.Parameters.AddWithValue("@Member_Adminpasswd", Member.Member_Adminpasswd);
                    cmd.Parameters.AddWithValue("@Member_Education", Member.Member_Education);
                    cmd.Parameters.AddWithValue("@Member_Email", Member.Member_Email);
                    cmd.Parameters.AddWithValue("@Member_Experience", Member.Member_Experience);
                    cmd.Parameters.AddWithValue("@Member_Mobile", Member.Member_Mobile);
                    cmd.Parameters.AddWithValue("@Member_Name", Member.Member_Name);
                    cmd.Parameters.AddWithValue("@Member_NowPosition", Member.Member_NowPosition);
                    cmd.Parameters.AddWithValue("@Member_Password", Member.Member_Password);
                    cmd.Parameters.AddWithValue("@Member_Picture", Member.Member_Picture);
                    
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