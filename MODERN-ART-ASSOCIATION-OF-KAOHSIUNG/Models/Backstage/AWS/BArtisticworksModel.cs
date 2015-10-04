using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;
using System.Collections.Generic;
using System.Data;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BArtisticworksModel : SharedMethod
    {
        public IList<Artisticworks> GetArtisticworks_B()
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

            DataTable table = ConnectDBToGetData(sql);

            IList<Artisticworks> objData = DataTableToList<Artisticworks>(table);
            return objData;
        }
    }
}