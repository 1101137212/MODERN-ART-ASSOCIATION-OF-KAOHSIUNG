using System;
using System.Data.SqlClient;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BArtisticworksModel : SharedMethod
    {
        //public void Create(Artisticworks Artisticworks)
        //{
        //    string sql = "INSERT INTO Artisticworks(Artisticworks_Name,Artisticworks_Date,Artisticworks_Picture,Member_ID) VALUES(@Artisticworks_Name,@Artisticworks_Date,@Artisticworks_Picture,@Member_ID)";
        //    using (SqlConnection conn = new SqlConnection(@"Server=(LocalDB)\v11.0;DataBase=MAAK;Trusted_Connection=True;"))
        //    {
        //        conn.Open();
        //        //int added = 0;
        //        using (SqlCommand cmd = new SqlCommand(sql, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@Artisticworks_Name", Artisticworks.Artisticworks_Name);
        //            cmd.Parameters.AddWithValue("@Artisticworks_Date", Artisticworks.Artisticworks_Date);
        //            cmd.Parameters.AddWithValue("@Artisticworks_Picture", Artisticworks.Artisticworks_Picture);
        //            cmd.Parameters.AddWithValue("@Member_ID", Artisticworks.Member_ID);

        //            try
        //            {
        //                cmd.ExecuteNonQuery();
        //            }
        //            catch (Exception)
        //            {
        //                Console.Write("error");
        //            }
        //            finally
        //            {
        //                conn.Close();
        //            }
        //        }
        //    }
        //}

        public void Delete(int Artisticworks_ID)
        {
            string sql = "DELETE FROM Artisticworks WHERE Artisticworks_ID=@Artisticworks_ID";
            using (SqlConnection conn = new SqlConnection(@"Server=(LocalDB)\v11.0;DataBase=MAAK;Trusted_Connection=True;"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Artisticworks_ID", Artisticworks_ID);
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

        public string GetArtisticworks()
        {
            string sql = "SELECT Artisticworks_Name,Artisticworks_Date,Artisticworks_Picture,Member_Name FROM Artisticworks LEFT JOIN Member ON Artisticworks.Member_ID = Member.Member_ID";
            return ConnectDBToGetData(sql);
        }

        public void Update(Artisticworks Artisticworks)
        {
            string sql = "UPDATE Artisticworks SET Artisticworks_Name=@Artisticworks_Name,Artisticworks_Date=@Artisticworks_Date,Artisticworks_Picture=@Artisticworks_Picture,Member_ID=@Member_ID WHERE Artisticworks_ID=@Artisticworks_ID";
            using (SqlConnection conn = new SqlConnection(@"Server=(LocalDB)\v11.0;DataBase=MAAK;Trusted_Connection=True;"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Artisticworks_Name", Artisticworks.Artisticworks_Name);
                    cmd.Parameters.AddWithValue("@Artisticworks_Date", Artisticworks.Artisticworks_Date);
                    cmd.Parameters.AddWithValue("@Artisticworks_Picture", Artisticworks.Artisticworks_Picture);
                    cmd.Parameters.AddWithValue("@Member_ID", Artisticworks.Member_ID);
                    cmd.Parameters.AddWithValue("@Artisticworks_ID", Artisticworks.Artisticworks_ID);
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