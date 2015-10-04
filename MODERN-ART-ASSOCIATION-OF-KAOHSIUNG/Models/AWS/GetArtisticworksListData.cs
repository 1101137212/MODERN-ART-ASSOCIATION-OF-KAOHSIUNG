using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.DefinedModel;
using System.Data.SqlClient;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models
{
    public partial class ArtisticworksModel : SharedMethod
    {
        public IList<GetArtisticworksByID> GetArtisticworksByID(GetArtisticworksByID obj)
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("SELECT ");
            sql.AppendLine("	Artisticworks_ID, ");
            sql.AppendLine("	Artisticworks_Name, ");
            sql.AppendLine("	Artisticworks_Date, ");
            sql.AppendLine("	Artisticworks_Picture, ");
            sql.AppendLine("	Member_Name ");
            sql.AppendLine("FROM Artisticworks ");
            sql.AppendLine("LEFT JOIN Member ");
            sql.AppendLine("	ON Artisticworks.Member_ID = Member.Member_ID ");
            sql.AppendLine("WHERE Artisticworks.Member_ID = @Member_ID");
            List<SqlParameter> parameter = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@Member_ID",Value = obj.Member_ID}
            };
            DataTable table = ConnectDBToGetData(sql, parameter);
            return DataTableToList<GetArtisticworksByID>(table);
        }
    }
}