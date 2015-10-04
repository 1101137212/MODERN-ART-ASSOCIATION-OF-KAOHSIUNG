using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;
using System.Collections.Generic;
using System.Data;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BPositionRecordModel : SharedMethod
    {
        public IList<PositionRecord> GetPositionRecord_B()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM PositionRecord ");

            DataTable table = ConnectDBToGetData(sql);

            IList<PositionRecord> objData = DataTableToList<PositionRecord>(table);
            return objData;
        }
    }
}