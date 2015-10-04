using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System;
using System.Data.SqlClient;
using System.Text;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;
using System.Data;
using System.Collections.Generic;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BMemberModel : SharedMethod
    {
        public IList<Member> GetMember_B()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM Member ");

            DataTable table = ConnectDBToGetData(sql);

            IList<Member> objData = DataTableToList<Member>(table);
            return objData;
        }
    }
}