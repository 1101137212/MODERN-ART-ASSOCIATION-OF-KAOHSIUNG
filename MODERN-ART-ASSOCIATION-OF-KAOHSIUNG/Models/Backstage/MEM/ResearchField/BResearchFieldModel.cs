﻿using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Text;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage
{
    public partial class BResearchFieldModel : SharedMethod
    {
        public string GetResearchField_B()
        {
            StringBuilder sql = new StringBuilder();
            
            sql.AppendLine("SELECT * FROM ResearchField ");

            return ConnectDBToGetData(sql);
        }
    }
}