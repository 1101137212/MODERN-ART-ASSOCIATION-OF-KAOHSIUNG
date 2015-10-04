using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;
using System.Data;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models
{
    public partial class AssociationEventModel : SharedMethod
    {
        public IList<AssociationEvent> GetAssociationEventListData()
        {
            StringBuilder sql = new StringBuilder();
            AssociationEvent obj = new AssociationEvent();
            sql = SqlBuilder.Query(obj);
            DataTable table = ConnectDBToGetData(sql);
            return DataTableToList<AssociationEvent>(table);

        }
    }
}