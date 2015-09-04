using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BExhibitionModel : SharedMethod
    {
        public string GetExhibition_B()
        {
            string sql = "SELECT * FROM Exhibition";
            return ConnectDBToGetData(sql);
        }
    }
}