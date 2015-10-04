﻿using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BResearchFieldModel : SharedMethod
    {
        public void DeleteResearchField_B(ResearchField obj)
        {
            StringBuilder sql = new StringBuilder();
            sql = SqlBuilder.Delete(obj);
            List<SqlParameter> parameter = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@ResearchField_ID",Value = obj.ResearchField_ID}
            };
            ConnectDBToSendData(sql, parameter);
        }
    }
}