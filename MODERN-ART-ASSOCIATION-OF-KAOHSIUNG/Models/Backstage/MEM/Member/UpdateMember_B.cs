using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Web.Configuration;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BMemberModel : SharedMethod
    {
        public void UpdateMember_B(Member obj)
        {
            StringBuilder sql = new StringBuilder();
            sql = SqlBuilder.Update(obj);
            List<SqlParameter> parameter = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@Member_Account", Value = obj.Member_Account},
                new SqlParameter() {ParameterName = "@Member_Address",Value = obj.Member_Address},
                new SqlParameter() {ParameterName = "@Member_Addresszip",Value = obj.Member_Addresszip},
                new SqlParameter() {ParameterName = "@Member_Adminname",Value = obj.Member_Adminname},
                new SqlParameter() {ParameterName = "@Member_Adminpasswd",Value = obj.Member_Adminpasswd},
                new SqlParameter() {ParameterName = "@Member_Education",Value = obj.Member_Education},
                new SqlParameter() {ParameterName = "@Member_Email",Value = obj.Member_Email},
                new SqlParameter() {ParameterName = "@Member_Experience",Value = obj.Member_Experience},
                new SqlParameter() {ParameterName = "@Member_Mobile",Value = obj.Member_Mobile},
                new SqlParameter() {ParameterName = "@Member_Name",Value = obj.Member_Name},
                new SqlParameter() {ParameterName = "@Member_NowPosition",Value = obj.Member_NowPosition},
                new SqlParameter() {ParameterName = "@Member_Password",Value = obj.Member_Password},
                new SqlParameter() {ParameterName = "@Member_Picture",Value = obj.Member_Picture},
                new SqlParameter() {ParameterName = "@Member_ID",Value = obj.Member_ID}
            };
            ConnectDBToSendData(sql, parameter);
        }
    }
}