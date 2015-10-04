using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;
using System.Collections.Generic;
using System.Data;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BPositionModel : SharedMethod
    {
        public IList<Position> GetPosition_B()
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("SELECT * FROM Position ");

            DataTable table = ConnectDBToGetData(sql);

            IList<Position> objData = DataTableToList<Position>(table);
            return objData;
        }
    }
}