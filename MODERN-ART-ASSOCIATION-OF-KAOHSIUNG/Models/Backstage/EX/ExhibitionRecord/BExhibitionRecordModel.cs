using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;
using System.Data;
using System.Collections.Generic;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BExhibitionRecordModel : SharedMethod
    {
        public IList<ExhibitionRecord> GetExhibitionRecord_B()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM ExhibitionRecord ");

            DataTable table = ConnectDBToGetData(sql);

            IList<ExhibitionRecord> objData = DataTableToList<ExhibitionRecord>(table);
            return objData;
        }
    }
}