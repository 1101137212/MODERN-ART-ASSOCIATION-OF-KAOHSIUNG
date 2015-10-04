using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;
using System.Data;
using System.Collections.Generic;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BMeetingRecordModel : SharedMethod
    {
        public IList<MeetingRecord> GetMeetingRecord_B()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM MeetingRecord ");
            DataTable table = ConnectDBToGetData(sql);

            IList<MeetingRecord> objData = DataTableToList<MeetingRecord>(table);
            return objData;
        }
    }
}