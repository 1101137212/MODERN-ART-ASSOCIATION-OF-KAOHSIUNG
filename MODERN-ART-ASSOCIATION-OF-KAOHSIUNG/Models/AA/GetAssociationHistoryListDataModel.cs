using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;
using System.Data;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models
{
    public partial class AssociationHistoryModel : SharedMethod
    {
        public IList<AssociationHistory> GetAssociationHistoryListData()
        {
            StringBuilder sql = new StringBuilder();
            AssociationHistory obj= new AssociationHistory();
            sql = SqlBuilder.Query(obj);
            DataTable table = ConnectDBToGetData(sql);
            return DataTableToList<AssociationHistory>(table);

        }
    }
}