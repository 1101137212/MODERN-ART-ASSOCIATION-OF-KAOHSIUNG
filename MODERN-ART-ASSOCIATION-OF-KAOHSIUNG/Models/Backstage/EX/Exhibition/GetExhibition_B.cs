using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;
using System.Collections.Generic;
using System.Data;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BExhibitionModel : SharedMethod
    {
        public IList<Exhibition> GetExhibition_B()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM Exhibition ");

            DataTable table = ConnectDBToGetData(sql);

            IList<Exhibition> objData = DataTableToList<Exhibition>(table);
            return objData;
        }
    }
}