using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BArtisticworksModel : SharedMethod
    {        
        public string GetArtisticworks_B()
        {
            string sql = "SELECT Artisticworks_ID,Artisticworks_Name,Artisticworks_Date,Artisticworks_Picture,Member_Name FROM Artisticworks LEFT JOIN Member ON Artisticworks.Member_ID = Member.Member_ID";
            return ConnectDBToGetData(sql);
        }        
    }
}