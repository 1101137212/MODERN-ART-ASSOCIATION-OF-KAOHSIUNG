﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BAA
{
    public partial class BAAController : Controller
    {
        public string GetAssociationHistorydata_B()
        {
            return BAHModel.GetAssociationHistory_B();
        }
        public void CreateAssociationHistorydata_B(AssociationHistory AssociationHistory)
        {
            BAHModel.CreateAssociationHistory_B(AssociationHistory);
        }
        public void UpdateAssociationHistorydata_B(AssociationHistory AssociationHistory)
        {
            BAHModel.UpdateAssociationHistory_B(AssociationHistory);
        }
        public void DeleteAssociationHistorydata_B(int AssociationHistory_ID)
        {
            BAHModel.DeleteAssociationHistory_B(AssociationHistory_ID);
        }
    }
}