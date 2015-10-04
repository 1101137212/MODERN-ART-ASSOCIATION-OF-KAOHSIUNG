using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;
using System.Data;
using System.Collections.Generic;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BAwardModel : SharedMethod
    {
        public IList<Award> GetAward_B()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM Award ");

            DataTable table = ConnectDBToGetData(sql);

            IList<Award> objData = DataTableToList<Award>(table);
            return objData;
        }
    }
}