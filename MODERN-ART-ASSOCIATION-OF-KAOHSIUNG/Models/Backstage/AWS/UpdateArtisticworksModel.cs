﻿using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BArtisticworksModel : SharedMethod
    {
        public void UpdateArtisticworks_B(Artisticworks Artisticworks)
        {
            string sql = "UPDATE Artisticworks SET Artisticworks_Name=@Artisticworks_Name,Artisticworks_Date=@Artisticworks_Date,Artisticworks_Picture=@Artisticworks_Picture,Member_ID=@Member_ID WHERE Artisticworks_ID=@Artisticworks_ID";
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MAAKDB"].ConnectionString))
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