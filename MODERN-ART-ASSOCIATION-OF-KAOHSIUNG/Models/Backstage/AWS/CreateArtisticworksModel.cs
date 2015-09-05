﻿using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BArtisticworksModel : SharedMethod
    {
        public void CreateArtisticworks_B(Artisticworks Artisticworks)
        {
            string sql = "INSERT INTO Artisticworks(Artisticworks_Name,Artisticworks_Date,Artisticworks_Picture,Member_ID) VALUES(@Artisticworks_Name,@Artisticworks_Date,@Artisticworks_Picture,@Member_ID)";
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MAAKDB"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Artisticworks_Name", Artisticworks.Artisticworks_Name);
                    cmd.Parameters.AddWithValue("@Artisticworks_Date", Artisticworks.Artisticworks_Date);
                    cmd.Parameters.AddWithValue("@Artisticworks_Picture", Artisticworks.Artisticworks_Picture);
                    cmd.Parameters.AddWithValue("@Member_ID", Artisticworks.Member_ID);

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