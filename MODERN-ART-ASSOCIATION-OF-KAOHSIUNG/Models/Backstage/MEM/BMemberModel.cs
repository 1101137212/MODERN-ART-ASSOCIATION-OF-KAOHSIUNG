using System;
using System.Data.SqlClient;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public class BMemberModel : SharedMethod
    {
        public string GetMember()
        {
            string sql = "SELECT Member.Member_ID,Member_Name,Member_Mobile,Member_Addresszip,Member_Address,Member_Picture,Member_Email,Member_Nowposition,Member_Education,Member_Experience,Position_Name FROM Member LEFT JOIN PositionRecord ON PositionRecord.Member_ID=Member.Member_ID LEFT JOIN Position ON Position.Position_ID=PositionRecord.Position_ID";
            return ConnectDBToGetData(sql);
        }
    }
}