using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;
using System.Data;
using System.Collections.Generic;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BResearchFieldRecordModel : SharedMethod
    {
        public IList<ResearchFieldRecord> GetResearchFieldRecord_B()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM ResearchFieldRecord ");

            DataTable table = ConnectDBToGetData(sql);

            IList<ResearchFieldRecord> objData = DataTableToList<ResearchFieldRecord>(table);
            return objData;
        }

    }
}