using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;
using System.Data;
using System.Collections.Generic;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BMediaReportsModel : SharedMethod
    {
        public IList<MediaReports> GetMediaReports_B()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM MediaReports ");

            DataTable table = ConnectDBToGetData(sql);

            IList<MediaReports> objData = DataTableToList<MediaReports>(table);
            return objData;
        }
    }
}