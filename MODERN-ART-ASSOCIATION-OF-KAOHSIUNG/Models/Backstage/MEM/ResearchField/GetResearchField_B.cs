using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;
using System.Data;
using System.Collections.Generic;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BResearchFieldModel : SharedMethod
    {
        public IList<ResearchField> GetResearchField_B()
        {
            StringBuilder sql = new StringBuilder();
            
            sql.AppendLine("SELECT * FROM ResearchField ");

            DataTable table = ConnectDBToGetData(sql);

            IList<ResearchField> objData = DataTableToList<ResearchField>(table);
            return objData;
        }
    }
}